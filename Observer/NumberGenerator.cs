using System;
using System.Collections.Generic;

namespace Gushwell.DesignPatterns {

    // 発行者クラスは、IObservable<T>を実装するのがC#流

    public abstract class NumberGenerator : IObservable<int> {

        private List<IObserver<int>> _observers = new List<IObserver<int>>();

        // イベントを発行する。通知する相手が誰かは把握していない。
        // これだけで、登録されている複数のオブジェクトに通知できる。
        protected void OnStepped(int number) {
            foreach (var observer in _observers) {
                observer.OnNext(number);
            }
        }

        // 数を生成する
        public abstract void Execute();

        public IDisposable Subscribe(IObserver<int> observer) {
            _observers.Add(observer);
            return observer as IDisposable;
        }
    }
}