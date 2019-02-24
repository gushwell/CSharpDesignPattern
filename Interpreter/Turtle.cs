using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace InterpreterSample {

    // このクラスは完全に独自に実装（オリジナルとは異なります）
    public class Turtle : IDisposable {
        public Direction Direction { get; set; }
        public Point Current { get; set; }
        public Graphics Graphics { get; set; }
        public Pen Pen { get; set; }
        public bool IsDelay { get; set; }

        public Turtle(Graphics graphics) {
            Direction = Direction.Up;
            Pen = new Pen(Color.LightGray, 3);
            IsDelay = false;
            Graphics = graphics;

        }

        public void Run(string cmdname) {
            IExecutor executor;
            switch (cmdname) {
                case "go":
                    executor = new GoExecutor();
                    break;
                case "right":
                    executor = new TurnRightExecutor();
                    break;
                case "left":
                    executor = new TurnLeftExecutor();
                    break;
                default:
                    return;
            }
            executor.Execute(this);
        }

        //private Point Go() {
        //    Point newpoint;
        //    switch (Direction) {
        //        case Direction.Up:
        //            newpoint = new Point(Current.X, Current.Y - 15);
        //            break;
        //        case Direction.Down:
        //            newpoint = new Point(Current.X, Current.Y + 15);
        //            break;
        //        case Direction.Right:
        //            newpoint = new Point(Current.X + 15, Current.Y);
        //            break;
        //        default: // case Direction.Left:
        //            newpoint = new Point(Current.X - 15, Current.Y);
        //            break;
        //    }
        //    Graphics.DrawLine(Pen, Current, newpoint);
        //    if (IsDelay)
        //        System.Threading.Thread.Sleep(30);
        //    return newpoint;
        //}

        //private static Direction ToLeft(Direction direction) {
        //    switch (direction) {
        //        case Direction.Up:
        //            return Direction.Left;
        //        case Direction.Left:
        //            return Direction.Down;
        //        case Direction.Down:
        //            return Direction.Right;
        //        default: // case Direction.Right:
        //            return Direction.Up;
        //    }
        //}

        //private static Direction ToRight(Direction direction) {
        //    switch (direction) {
        //        case Direction.Up:
        //            return Direction.Right;
        //        case Direction.Left:
        //            return Direction.Up;
        //        case Direction.Down:
        //            return Direction.Left;
        //        default: // case Direction.Right:
        //            return Direction.Down;
        //    }
        //}


        // 手抜き
        public void Dispose() {
            Pen.Dispose();
            Graphics.Dispose();
        }
    }

    public enum Direction {
        Up = 0,
        Right,
        Down,
        Left,
    }

    interface IExecutor {

        void Execute(Turtle turtle);

    }

    class TurnLeftExecutor : IExecutor {
        public void Execute(Turtle turtle) {
            turtle.Direction = (Direction)(((int)turtle.Direction - 1) % 4);
            //switch (turtle.Direction) {
            //    case Direction.Up:
            //        turtle.Direction = Direction.Left;
            //        break;
            //    case Direction.Left:
            //        turtle.Direction = Direction.Down;
            //        break;
            //    case Direction.Down:
            //        turtle.Direction = Direction.Right;
            //        break;
            //    default: // case Direction.Right:
            //        turtle.Direction = Direction.Up;
            //        break;
            //}
        }
    }

    class TurnRightExecutor : IExecutor {
        public void Execute(Turtle turtle) {
            turtle.Direction = (Direction)(((int)turtle.Direction + 1) % 4);
            //switch (turtle.Direction) {
            //    case Direction.Up:
            //        turtle.Direction = Direction.Right;
            //        break;
            //    case Direction.Left:
            //        turtle.Direction = Direction.Up;
            //        break;
            //    case Direction.Down:
            //        turtle.Direction = Direction.Left;
            //        break;
            //    default: // case Direction.Right:
            //        turtle.Direction = Direction.Down;
            //        break;
            //}
        }
    }


    class GoExecutor : IExecutor {
        public void Execute(Turtle turtle) {
            Point newpoint;
            switch (turtle.Direction) {
                case Direction.Up:
                    newpoint = new Point(turtle.Current.X, turtle.Current.Y - 15);
                    break;
                case Direction.Down:
                    newpoint = new Point(turtle.Current.X, turtle.Current.Y + 15);
                    break;
                case Direction.Right:
                    newpoint = new Point(turtle.Current.X + 15, turtle.Current.Y);
                    break;
                default: // case Direction.Left:
                    newpoint = new Point(turtle.Current.X - 15, turtle.Current.Y);
                    break;
            }
            turtle.Graphics.DrawLine(turtle.Pen, turtle.Current, newpoint);
            if (turtle.IsDelay)
                System.Threading.Thread.Sleep(50);
            turtle.Current = newpoint;
        }
    }

}
