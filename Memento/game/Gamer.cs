using System;
using System.Collections.Generic;
using System.Linq;
using Gushwell.Dejavu;

namespace Gushwell.DesignPatterns.Game {
    // Mementoクラスを使い、インスタンスの保存、復元の機能を持たせている。
    // Originatorに該当するクラス
    public class Gamer {


        // フルーツ
        private ICollection<string> fruits = new List<string>();

        // 乱数発生器
        private Random random = new Random();

        private static string[] fruitsname = new string[] { "リンゴ", "ぶどう", "バナナ", "みかん" };

        // コンストラクタ
        public Gamer(int money) {
            this.Money = money;
        }

        // 現在の所持金
        public int Money { get; private set; }

        public void Bet() {
            // 賭ける…ゲームの進行
            // サイコロを振る
            var dice = random.Next(6) + 1; 
            if (dice == 1) {
                // 1の目…所持金が増える
                Money += 100;
                Console.WriteLine("所持金が増えました。");
            } else if (dice == 2) {
                // 2の目…所持金が半分になる
                Money /= 2;
                Console.WriteLine("所持金が半分になりました。");
            } else if (dice == 6) {
                // 6の目…フルーツをもらう
                var f = GetFruit();
                Console.WriteLine("フルーツ({0})をもらいました。",f);
                fruits.Add(f);
            } else {
                // それ以外…何も起きない
                Console.WriteLine("何も起こりませんでした。");
            }
        }

        // スナップショットをとる
        public Memento CreateMemento() {
            var m = new Memento(Money);
            // フルーツはおいしいものだけ保存
            fruits.Where(f => f.StartsWith("おいしい"))
                  .ForEach(f => m.AddFruit(f));
            return m;
        }

        // アンドゥを行う
        public void RestoreMemento(Memento memento) {
            this.Money = memento.Money;
            this.fruits = memento.GetFruits();
        }

        // 文字列表現
        public override string ToString() {
            var s = string.Join(", ", fruits.ToArray());
            return string.Format("[money = {0}, fruits = [{1}]]", Money, s);
        }

        // フルーツを1個得る
        private string GetFruit() {
            var prefix = "";
            if (random.Next(0, 2) == 0) {
                prefix = "おいしい";
            }
            return prefix + fruitsname[random.Next(fruitsname.Length)];
        }
    }
}