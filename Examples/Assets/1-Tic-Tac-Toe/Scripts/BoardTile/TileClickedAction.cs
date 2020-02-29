using AReSSO;
using UnityEngine;

namespace TicTacToe.BoardTile
{
    /// An action notifying when a tile is clicked. Action names should follow the convention of ending with "Action"
    public class TileClickedAction : IAction
    {
        public Vector2Int Location { get; }

        public TileClickedAction(Vector2Int location)
        {
            Location = location;
        }

        /// This to string implementation will eventually be replaced with a generic version on the Action base class
        /// Ideally, once the devtools are ready, printing out actions to the logs will not be necessary.
        public override string ToString() => $"{GetType().Name}: {{ {nameof(Location)}: {Location} }}";
    }
}