using GameMandatory;
using GameMandatory.Models.World;
using GameMandatory.Models;
using GameMandatory.XMLFiles.LoadFiles;
using GameMandatory.Models.Creatures;

XmlLoadFil.LoadWorld();

Creature monster = new Monster("Kat", 200, 3, 1, new Position(10,10));

monster.ReceiveDamage(1);
monster.ReceiveDamage(3);
monster.ReceiveDamage(5);
