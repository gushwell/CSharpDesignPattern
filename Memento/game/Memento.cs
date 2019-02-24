using System.Collections.Generic;

namespace Gushwell.DesignPatterns.Game {

    // オブジェクトのスナップショットを保持しておく
    public class Memento  {
        // フルーツ
        private ICollection<string> fruits = new List<string>();

        // 所持金を得る(narrow interface)
        public int Money { get; }

        // コンストラクタ(wide interface)
        public Memento(int money) {
            this.Money = money;
        }

        // フルーツを追加する(wide interface)
        public void AddFruit(string fruit) {
            fruits.Add(fruit);
        }

        // フルーツを得る(wide interface)
        public ICollection<string> GetFruits() {
            // 複製して返している
            return new List<string>(fruits);
        }

    }
}