using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMandatory.Interfaces;
using GameMandatory.Models;
using GameMandatory.Models.World;
using GameMandatory.TraceLogger;

namespace GameMandatory
{
    /// <summary>
    /// Repræsenterer min spilleverden
    /// Metoder: GetWorld(), AddObject(), RemoveObject(), FindObjectAtPosition(), AddCreature() og RemoveCreature()
    /// </summary>
    public class World
    {
        // En statisk variabel til at gemme den eneste instans af verden
        private static World _instance;
        private World() { }

        public static World Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new World(50, 50);
                }
                return _instance;
            }
        }

        public World(int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;
            Creatures = new List<Creature>();
            WorldObjects = new List<WorldObject>();
        }

        // Egenskab til at indeholde alle objekter i verden
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public List<WorldObject> WorldObjects { get; private set; }
        public List<Creature> Creatures { get; private set; }

        // Funktion til at tilføje objekter
        public void AddObject(WorldObject worldObject)
        {
            WorldObjects.Add(worldObject);
            Logger.Log($"{worldObject.Name} has been added");
        }

        // Funktion til at fjerne objekter
        public void RemoveObject(WorldObject worldObject)
        {
            WorldObjects.Remove(worldObject);
            Logger.Log($"{worldObject.Name} has been removed");

        }

        // Funktion til at finde objekter på en bestemt position i verden
        public WorldObject FindObjectAtPosition(Position position)
        {
            return WorldObjects.Find(obj => obj.Position.X == position.X && obj.Position.Y == position.Y);
        }

        // Funktion til at tilføje creatures til verden
        public void AddCreature(Creature creature)
        {
            Creatures.Add(creature);
            Logger.Log($"{creature.Name} has been added");

        }

        // Funktion til at fjerne creatures i verden
        public void RemoveCreature(Creature creature)
        {
            Creatures.Remove(creature);
            Logger.Log($"{creature.Name} has been removed");
        }

        /*public void LoadMap()
        {
            for(int i = 0; i < MaxX; i++)
            {
                for (int j = 0; j < MaxY; j++)
                {

                }
            }
        }*/
    }
}
