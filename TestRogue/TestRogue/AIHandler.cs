using Microsoft.Xna.Framework.Input;

using Roy_T.AStar.Grids;
using Roy_T.AStar.Primitives;
using Roy_T.AStar.Paths;

using TestRogue.GameObjects;
using System.Collections.Generic;

namespace TestRogue
{
    public class AIHandler : InputHandler
    {
        PathFinder pathFinder = new PathFinder();
        Grid grid = Grid.CreateGridWithLateralConnections(new GridSize(100, 100), new Size(Distance.FromMeters(1), Distance.FromMeters(1)), Velocity.FromMetersPerSecond(1));

        public TestRogue.Position targetPosition;


        public void SetTargetPosition()
        {
            targetPosition = Game1.gameObjects.Find(x => x is Player).position;
        }

        public List<Position> DrawPath()
        {
            Path path = pathFinder.FindPath(((GameObject)Owner).position, targetPosition, grid);

            List<Position> positions = new List<Position>();
            for (int i = 0; i < path.Edges.Count; i++)
            {
                positions.Add(new Position(path.Edges[i].End.Position));
            }

            return positions;
        }

        public void HandleAiInput(Position position)
        {
            if (((GameObject)Owner).position.X < position.X)
            {
                currentAction = Actions.Right;
                ((GameObject)Owner).SetToHasActed();
            }
            else if (((GameObject)Owner).position.X > position.X)
            {
                currentAction = Actions.Left;
                ((GameObject)Owner).SetToHasActed();
            }
            else if (((GameObject)Owner).position.Y > position.Y)
            {
                currentAction = Actions.Up;
                ((GameObject)Owner).SetToHasActed();
            }
            else if (((GameObject)Owner).position.Y < position.Y)
            {
                currentAction = Actions.Down;
                ((GameObject)Owner).SetToHasActed();
            }
        }

        public override void Update()
        {
            SetTargetPosition();
            List<Position> path = DrawPath();
            HandleAiInput(path[0]);
        }

    }
}
