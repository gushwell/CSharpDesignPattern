using System;
using System.Drawing;
using Gushwell.DesignPatterns.Command;

namespace Gushwell.DesignPatterns.Drawer {

    // Commandの具象クラス
    public class DrawCommand : ICommand {
        // 描画対象
        protected internal IDrawable drawable;

        // 描画位置
        private Point position;

        // コンストラクタ
        public DrawCommand(IDrawable drawable, Point position) {
            this.drawable = drawable;
            this.position = position;
        }

        // 実行
        public virtual void Execute() {
            drawable.Draw(position.X, position.Y);
        }
    }
}