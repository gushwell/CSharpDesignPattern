using System;
using System.Collections.Generic;

namespace Gushwell.DesignPatterns {
    // たくさんの BigCharインスタンスが生成されないように管理する。
    public sealed class BigCharFactory {
        // すでに作ったBigCharのインスタンスを管理
        private Dictionary<char, BigChar> pool = new Dictionary<char, BigChar>();

        // Singletonパターン 唯一のインスタンスを得る
        public static BigCharFactory Instance { get; } = new BigCharFactory();


        // コンストラクタ
        private BigCharFactory() {
        }

        // BigCharのインスタンス生成(共有)
        public BigChar GetBigChar(char charname) {
            lock (this) {
                BigChar bc = null;
                if (pool.ContainsKey(charname)) {
                    // 生成済みならば、poolにあるインスタンスを返す。
                    bc = pool[charname];
                } else {
                    // ここでBigCharのインスタンスを生成
                    bc = new BigChar(charname); 
                    pool[charname] = bc;
                }
                return bc;
            }
        }
    }
}

