using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ActorClassLibrary
{
    public class ActorRepository : IActor
    {
        /// <summary>
        /// Privat liste over skuespillere.
        /// </summary>
        private List<Actor> _actors = new List<Actor>()
        {
            new Actor("jakob", 1, 2014),
            new Actor ("Abdi",2, 2018),
        };

        /// <summary>
        /// Henter alle skuespillere.
        /// </summary>
        /// <returns>En liste over alle skuespillere.</returns>
        public List<Actor> GetAll()
        {
            return _actors;
        }

        /// <summary>
        /// Henter en skuespiller ud fra et ID.
        /// </summary>
        /// <param name="id">ID'et på skuespilleren, der skal hentes.</param>
        /// <returns>Skuespilleren med det angivne ID eller null, hvis ingen findes.</returns>
        public Actor GetById(int id)
        {
            return _actors.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Tilføjer en ny skuespiller til samlingen.
        /// </summary>
        /// <param name="actor">Den skuespiller, der skal tilføjes.</param>
        /// <returns>Den tilføjede skuespiller.</returns>
        public Actor Add(Actor actor)
        {
            _actors.Add(actor);
            return actor;
        }

        /// <summary>
        /// Sletter en skuespiller baseret på ID.
        /// </summary>
        /// <param name="id">ID'et på skuespilleren, der skal slettes.</param>
        /// <returns>Den slettede skuespiller eller null, hvis ingen findes.</returns>
        public Actor Delete(int id)
        {
            Actor actor = GetById(id);
            if (actor == null)
            {
                return null;
            }
            _actors.Remove(actor);
            return actor;
        }

        /// <summary>
        /// Henter alle skuespillere.
        /// </summary>
        /// <returns>En liste over alle skuespillere.</returns>
        public List<Actor> GetActors()
        {
            return _actors;
        }

        /// <summary>
        /// Opdaterer en eksisterende skuespiller.
        /// </summary>
        /// <param name="id">ID'et på skuespilleren, der skal opdateres.</param>
        /// <param name="actor">Den nye skuespillerdata.</param>
        /// <returns>Den opdaterede skuespiller eller null, hvis ingen findes.</returns>
        public Actor Update(int id, Actor actor)
        {
            actor.Validate();
            Actor actorToUpdate = GetById(id);
            if (actorToUpdate == null)
            {
                return null;
            }
            actorToUpdate.Name = actor.Name;
            actorToUpdate.BirthYear = actor.BirthYear;
            return actorToUpdate;
        }

    }
}
