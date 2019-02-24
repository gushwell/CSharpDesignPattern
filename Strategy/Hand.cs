using System;
using System.Collections.Generic;

namespace Gushwell.Design.Patterns {

    // このクラスはオリジナルとは大きく変更
    public struct Hand {
        public static readonly int GUU = 0; // グーを表す値
        public static readonly int CHO = 1; // チョキを表す値
        public static readonly int PAA = 2; // パーを表す値
        private static readonly string[] name = new string[] { "グー", "チョキ", "パー" };

        // コンストラクタ (GUU, CHO, PAAを引数に渡す)
        public Hand(int handvalue) {
            if (handvalue < 0 || 2 < handvalue)
                throw new ArgumentException();
            this.Value = handvalue;
        }

        // handValueを返す
        public int Value { get; }

        // グー、チョキ、パーを返す
        public string GetName() {
            return name[Value];
        }

        // このHnadに勝つ Handを得る
        public Hand StrongHand() {
            return (Hand)((Value + 2) % 3);
        }

        // 値からインスタンスを得る
        public static Hand GetHand(int handvalue) {
            return new Hand(handvalue);
        }

        // Handから　intへの型変換
        public static implicit operator Int32(Hand hand) {
            return hand.Value;
        }

        // intからHnadへの型変換
        public static implicit operator Hand(int value) {
            return new Hand(value);
        }

        // Handを列挙するためのメソッド（循環）
        public Hand NextHand() {
            var value = Value + 1;
            if (value >= 3)
                value = 0;
            return new Hand(value);
        }

        // Handを列挙
        public static IEnumerable<Hand> GetValues() {
            yield return new Hand(GUU);
            yield return new Hand(CHO);
            yield return new Hand(PAA);
        }

        // thisがhより強いときtrue
        public bool IsStrongerThan(Hand h) {
            return Fight(h) == 1;
        }

        // thisがhより弱いときtrue
        public bool IsWeakerThan(Hand h) {
            return Fight(h) == -1;
        }

        // 引き分けは0, thisの勝ちなら1, hの勝ちなら-1
        private int Fight(Hand h) {
            if (this.Equals(h)) {
                return 0;
            } else if (this.Equals(h.StrongHand())) {
                return 1;
            } else {
                return -1;
            }
        }

        // 文字列表現へ変換
        public override string ToString() {
            return this.GetName();
        }


        public override bool Equals(object obj) {
            if (obj is Hand)
                return this.Value == ((Hand)obj).Value;
            return false;
        }

        public override int GetHashCode() {
            return this.Value.GetHashCode();
        }
    }
}