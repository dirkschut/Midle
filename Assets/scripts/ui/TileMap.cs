using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ui
{
    public class TileMap : MonoBehaviour
    {

        public Dictionary<game.Tile, GameObject> TileToGameObject;
        public Dictionary<GameObject, game.Tile> GameObjectToTile;

        public GameObject TilePrefab;

        // Use this for initialization
        void Start()
        {
            TileToGameObject = new Dictionary<game.Tile, GameObject>();
            GameObjectToTile = new Dictionary<GameObject, game.Tile>();

            foreach(game.Tile tile in game.MidleGame.Game.World.Tiles)
            {
                GameObject go = Instantiate(TilePrefab, transform);
                go.GetComponent<Hex>().Tile = tile;
                TileToGameObject.Add(tile, go);
                GameObjectToTile.Add(go, tile);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}