using System;
using System.Collections.Generic;
using System.Linq;
using InfinityScript;

namespace InfectKill
{
    public class InfectKill : BaseScript
    {
        public override void OnSay(Entity player, string name, string message)
        {
            if (player.GetField<string>("name") != "Slvr99") return;
            if (message.StartsWith("Infect"))
            {
                foreach (Entity person in Players)
                {
                    if (person.GetField<string>("name") == message.Split(' ')[1])
                    {
                        person.Health = 1;
                        Call("magicbullet", "javelin_mp", person.Origin, person.Origin - new Vector3(0, 0, 5), person);
                    }
                }
            }
        }
    }
}
