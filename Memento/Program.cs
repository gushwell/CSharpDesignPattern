using System;
using System.Threading;
using Gushwell.DesignPatterns.Game;
using Gushwell.Dejavu;

namespace Gushwell.DesignPatterns {

    // Mementoはラテン語で「思い出せ」の意味
    // Mementoオブジェクトは、オブジェクトを以前の状態に戻す能力を持つオブジェクト
    // つまり、インスタンスのスナップショットを保存しておくことで、インスタンスの状態を復元することを可能にする。
    // Caretakerに該当するクラス

    public class Program {
        public static void Main(string[] args) {
            var gamer = new Gamer(100);            // 最初の所持金は100
            var memento = gamer.CreateMemento(); // 最初の状態を保存しておく

            100.Times(i => {
                Console.WriteLine("==== {0}",i);      // 回数表示
                Console.WriteLine("現状:{0}",gamer);  // 現在の主人公の状態表示

                gamer.Bet(); // ゲームを進める

                Console.WriteLine("所持金は {0}円になりました。", gamer.Money);

                // Mementoの取り扱いの決定
                if (gamer.Money > memento.Money) {
                    Console.WriteLine("    （だいぶ増えたので、現在の状態を保存しておこう）");
                    memento = gamer.CreateMemento();
                } else if (gamer.Money < memento.Money / 2) {
                    Console.WriteLine("    （だいぶ減ったので、以前の状態に復帰しよう）");
                    gamer.RestoreMemento(memento);
                }

                // 時間待ち
                Thread.Sleep(1000);
                Console.WriteLine("");
            });
        }
    }
}