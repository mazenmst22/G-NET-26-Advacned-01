using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_Advacned_01
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            #region Q1
            //Q1: What is a generic class? Why use generics?
            //Answer:
            //A Generic class is a class definition that acts as a template
            //that can be used to write reusable code that can work with any data type.
            //Why we use Generics:
            //To make the code more reusable and optimize performance, as 
            //we can use the same template for different data types, on 
            //the other hand, Object class can also use the same template 
            //for different data types using boxing/unboxing
            //But it will not be optimized as the boxing/unboxing drains 
            //memory and performance.
            #endregion
            #region Q2
            //Q2: Write a generic class Container<T> with Add and Get methods.
            //Answer:
            /*
             *
                public class Container<T>
                    {
                        private T val;
                        public void Add(T val)
                        {
                                       this.val = val;
                        }
                        public T Get()
                        {
                            return val;
                        }
                    }
             * 
             * See Q2 folder for answer code.
             * 
             */
            #endregion
            #region Q3
            //Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
            //Answer:
            //It is a generic thjat has more than one type parameter,
            //it is use when we want to handle different data types simultaneously,
            //It is made using a class that has a different constraints for different type parameters.
            //Example:
            /*
             *
                public class Pair<T, U>
                    where T : struct
                    where U : class
                {
                    private T key;
                    private U value;
                    public Pair(T key, U value)
                    {
                        this.key = key;
                        this.value = value;
                    }
                    public T GetKey()
                    {
                        return key;
                    }
                    public U GetValue()
                    {
                        return value;
                    }
                    public override string ToString()
                    {
                        return $"Key: {key}, Value: {value}";
                    }
                }
             * 
             * See Q3 folder for answer code.
             * 
             */

            #endregion
            #region Q4
            //Q4: What is a generic method? Write Swap<T> method.
            //It is a method declared with the actual type parameter
            //Example using Swap<T>() method
            /*
             * public void Swap<T>(T a,T b)
            {
                if (a == null || b==null) return;
                T temp = a;
                a = b;
                b = temp;

            }
             * 
             * 
             */

            #endregion
            #region Q5
            //Q5: Write a generic method FindMax<T> that finds maximum value
            /*Answer:
             * public static T FindMax<T>(T[] items) where T : IComparable<T>
                {
                    if (items.Length == 0)
                    {
                        throw new Exception("The array is empty!");
                    }
                    T biggest = items[0];

                    for (int i = 1; i < items.Length; i++)
                    {
                        if (items[i].CompareTo(biggest) > 0)
                        {
                            biggest = items[i];
                        }
                    }
                    return biggest;
                }
             * 
             * see Q5 folder for answer code.
             * 
             */
            #endregion
            #region Q6
            //What is a generic interface? Write IRepository<T>
            //Answer:
            //It is an interface that has a type parameter,
            //it is used to define a contract for classes that will implement it,
            //and it allows us to write reusable code that can work with any data type.
            //Example:
            //public interface IRepository<T> where T : class
            //{
            //T GetById(int id);
            //IEnumerable<T> GetAll();
            //void Add(T entity);
            //void Update(T entity);
            //void Delete(T entity);
            //}
            //see Q6 folder for answer code.

            #endregion
            #region Q7
            //What is the 'struct' constraint? Write an example.
            //Answer:
            //It is a constraint that specifies that the type parameter must be a value type,
            //Eg: int , double, bool, etc.
            //Example:
            /*
              public class Point<T> where T : struct
             {
                 public T X { get; set; }
                 public T Y { get; set; }
                public T Z { get; set; }

                public Point(T x, T y, T z)
                {
                    X = x;
                    Y = y;
                    Z = z;
                }
                public void DisplayCoordinates()
                {
                    Console.WriteLine($"Point coordinates: ({X}, {Y}, {Z})");
                }
               }
             * 
             * for answer code see Q7 folder.
             * 
             * 
             * 
             * 
             * 
             */

            #endregion
            #region Q8
            //What is the 'class' constraint? Write an example.
            //Answer:
            //It is a constraint which specifies that the type parameter must be a reference type, 
            //Eg: string, object, etc.
            //Example:
            /*
             * public class MyRepository<T> where T : class
                {
                    private List<T> items = new List<T>();
                    public void Add(T item)
                    {
                        items.Add(item);
                    }
                    public IEnumerable<T> GetAll()
                    {
                        return items;
                    }
                }
             * 
             * 
             */
            #endregion
            #region Q9
            //What is the 'new()' constraint? Write an example.
            //Answer:
            //It is a constraint that specifies that the type parameter must have a public parameterless constructor,
            //Example:
            /*
             * public class Factory<T> where T : new()
                {
                    public T CreateInstance()
                    {
                        return new T();
                    }
                }
             * 
             * 
             */
            #endregion
            #region Q10
            //What is the interface constraint? Write an example.
            //Answer:
            //It is a constraint that specifies that the type parameter must implement a specific interface,
            //Example:
            /*
             * public class Point3D<T> where T : IDisplay<T>
            {
            public T X { get; set; }
            public T Y { get; set; }
            public T Z { get; set; }

            public Point3D(T x, T y, T z)
            {
            X = x;
            Y = y;
            Z = z;
            }
                public void DisplayCoordinates()
            {
            Console.WriteLine($"Point coordinates: ({X}, {Y}, {Z})");
            }
            * 
             * 
             */
            #endregion
            #region Q11
            //What is the base class constraint? Write an example.
            //Answer:
            //It is a constraint that specifies that the type parameter must be or derive from a specific base class,
            //Example:
            /*
             * public class Repository<T> where T : BaseEntity
                {
                    private List<T> items = new List<T>();
                    public void Add(T item)
                    {
                        items.Add(item);
                    }
                    public IEnumerable<T> GetAll()
                    {
                        return items;
                    }
                }
             * 
             * 
             */
            #endregion
        }
    }

}
