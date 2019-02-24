using System.Drawing;
using System.Windows.Forms;
using Gushwell.DesignPatterns.Command;

namespace Gushwell.DesignPatterns.Drawer {

    // UserControlを継承すると共に、IDrawableインターフェースを実装する。
    public partial class DrawCanvas : UserControl, IDrawable {
        public DrawCanvas() {
            InitializeComponent();
        }
        // 描画色
        private Color color = Color.Red;
        // 描画する点の半径
        private int radius = 6;
        // 履歴
        private MacroCommand history = null;

        public void Draw(int x, int y) {
            using (var g = CreateGraphics()) 
            using (var brush = new SolidBrush(color)) {
                g.FillEllipse(brush, x - radius, y - radius, radius * 2, radius * 2);
            }
        }

        // 本当はコンストラクタで行ないたい。
        // 初期化用メソッド
        public void SetHistory(MacroCommand history) {
            this.history = history;
        }

        // これが無いと、最小化から戻したときなどに、再描画されない。
        private void DrawCanvas_Paint(object sender, PaintEventArgs e) {
            if (history != null)
                history.Execute();
        }

    }
}
