using System.Collections.Generic;

namespace TestRogue
{
    /// <summary>
    /// A class containing <see cref="Component"/>s.
    /// </summary>
    public class Composite : Component
    {
        List<Component> components;

        public Composite()
        {
            components = new List<Component>();
        }

        /// <summary>
        /// Adds a Component to the <see cref="Composite"/>'s list.
        /// </summary>
        public void AddComponent(Component component)
        {
            components.Add(component);
        }

        /// <summary>
        /// Removes a Component from the <see cref="Composite"/>'s list.
        /// </summary>
        public void RemoveComponent(Component component)
        {
            components.Remove(component);
        }

        /// <summary>
        /// Returns the first <see cref="Component"/> of the give type.
        /// </summary>
        /// <typeparam name="T">The type of <see cref="Component"/> to find.</typeparam>
        /// <returns>The first <see cref="Component"/> of the give type</returns>
        public T GetComponent<T>() where T : Component
        {
            return (T)components.Find(x => x is T);
        }

        public List<T> GetComponents<T>() where T : Component
        {
            return components.FindAll(x => x is T).ConvertAll(x=>((T)x));
        }

        /// <summary>
        /// Runs all containing <see cref="Component"/>'s Start methods.
        /// </summary>
        public override void Start()
        {
            foreach (var comp in components)
            {
                comp.Start();
            }
        }

        /// <summary>
        /// Runs all containing <see cref="Component"/>'s Update methods.
        /// </summary>
        public override void Update()
        {
            foreach (var comp in components)
            {
                comp.Update();
            }
        }

        /// <summary>
        /// Runs all containing <see cref="Component"/>'s Draw methods.
        /// </summary>
        public override void Draw()
        {
            foreach (var comp in components)
            {
                comp.Draw();
            }
        }
    }
}
