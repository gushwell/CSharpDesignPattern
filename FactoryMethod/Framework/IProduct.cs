using System;

namespace Gushwell.DesignPatterns.Framework {
    public interface IProduct { 
        void Use();
        // IProductのメンバーに変更（結城氏の意図とは異なる可能性があるが...）
        string Owner { get; }
    }
}