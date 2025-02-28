﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = new List<Group>();
            var students = new List<Student>();

            for (int i = 0; i < 10; i++)
            {
                groups.Add(new Group(i, "Група " + i));
            }

            for (int i = 0; i < 300; i++)
            {
                var studen = new Student($"Студент " + Guid.NewGuid().ToString().Substring(0, 5), i % 100)
                {
                    Group = groups[i%9]
                };

                students.Add(studen);
            }

            var binFormatter = new BinaryFormatter();

            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, groups);
            }



            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                var newGroups = binFormatter.Deserialize(file) as List<Group>;

                if (newGroups != null)
                {
                    foreach (var group in newGroups)
                    {
                        Console.WriteLine(group);
                    }
                }


            }

            //var soap = new SoapFormatter();






            Console.ReadLine();

        }
    }
}
