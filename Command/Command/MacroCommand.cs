
using System;
using System.Collections.Generic;
using Gushwell.Dejavu;

namespace Gushwell.DesignPatterns.Command {

    // 複数のCommandをまとめて実行するマクロ機能を実現する。
    // 具体的なCommandには依存しない。
    // MacroComamndもCommandなので、Executeで実行できる
    public class MacroCommand : ICommand {
        // 命令の集合
        private Stack<ICommand> commands = new Stack<ICommand>();

        // 実行
        public virtual void Execute() {
            commands.ForEach(cmd => cmd.Execute());
        }

        // 追加
        public virtual void Append(ICommand cmd) {
            if (cmd != this) {
                commands.Push(cmd);
            }
        }

        // 最後の命令を削除
        public virtual void Undo() {
            if (!(commands.Count == 0)) {
                commands.Pop();
            }
        }

        // 全部削除
        public virtual void Clear() {
            commands.Clear();
        }
    }
}