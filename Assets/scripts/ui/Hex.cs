using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ui
{
    public class Hex : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            this.transform.position = GetPosition();
        }

        public game.Tile Tile;

        public static readonly float RADIUS = 1f;
        public static readonly float WIDTH_MULTIPLIER = Mathf.Sqrt(3) / 2;

        // Update is called once per frame
        void Update()
        {

        }

        public Vector3 GetPosition()
        {
            return new Vector3(
                WIDTH_MULTIPLIER * 2 * RADIUS * (Tile.Column + Tile.Row/2f),
                2 * RADIUS * Tile.Row * 0.75f
                );
        }
    }
}