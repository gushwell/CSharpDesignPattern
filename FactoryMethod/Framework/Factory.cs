using System;
using System.Collections.Generic;

namespace Gushwell.DesignPatterns.Framework {

    public class ProductFactory<T> where T : class, IProduct {
        private List<string> owners = new List<string>();

        // T型のインスタンスを生成する。
        public T Create(string owner) {
            // IProductnの派生クラスにデフォルトコンストラクタを用意し、
            // Ownerを書き込み可のプロパティにすれば、わざわざリフレクションを
            // 使わなくても、以下のコードで良い。
            //   T p = new T();
            //   p.Owner = owner;
            // ただ、そうするとOwnerが読み込み専用のプロパティでなくなってしまう。
            var t = typeof(T);
            var product = Activator.CreateInstance(t, owner) as T;
            RegisterProduct(product);
            return product;
        }

        // Owners に登録
        private void RegisterProduct(T product) {
            owners.Add(product.Owner);
        }

        // Owners は、IEnumerableを返すように変更
        public IEnumerable<string> Owners {
            get { return owners; }
        }
    }
}
