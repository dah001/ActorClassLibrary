using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorClassLibrary
{
    interface IActor 
    {
        public List<Actor> GetAll();
        public Actor GetById(int id);
        public Actor Add(Actor actor);
        public Actor Delete(int id);
        public List<Actor> GetActors();
        public Actor Update(int id, Actor actor);

    }
}
