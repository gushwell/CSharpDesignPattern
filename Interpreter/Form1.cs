using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace InterpreterSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        
        private InterpreterFacade facade = new InterpreterFacade();


        private Turtle CreateTurtle() {
            var graphics = Panel.CreateGraphics();
            return new Turtle(graphics) {
                Current = new Point(Panel.Width / 3, Panel.Height / 2),
                IsDelay = true,
            };
        }

        private void Panel_Paint(object sender, PaintEventArgs e) {
            using (var turtle = CreateTurtle()) {
                facade.Run(turtle);
            }
        }

        private void RunButton_Click(object sender, EventArgs e) {
            if (facade.Parse(textBox1.Text)) {
                using (var turtle = CreateTurtle()) {
                    facade.Run(turtle);
                }
            }
        }

        private void RunButton_KeyUpDown(object sender, KeyEventArgs e) {
            facade.IsDebug = e.Shift;
        }

        private void ClearButton_Click(object sender, EventArgs e) {
            using (var turtle = CreateTurtle()) {
                facade.Clear(turtle);
            }
        }
    }

    class InterpreterFacade {
        public bool IsDebug { get; set; }

        private INode program;
        public bool Parse(string text) {
            try {
                program = new ProgramNode();
                program.Parse(new Context(text));
                return true;
            } catch(ParseException) {
                return false;
            }
        }

        public void Run(Turtle turtle) {
            if (program == null)
                return;
            turtle.Graphics.Clear(Color.White);
            program.Run(turtle);
            if (IsDebug)
                program.Print();
        }

        public void Clear(Turtle turtle) {
            turtle.Graphics.Clear(Color.White);
        }
    }
}