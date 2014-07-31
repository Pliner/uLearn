﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace uLearn.Courses.Linq.Slides
{
	[Slide("Объединение коллекций", "{7DB3F797-B99B-4580-ABE6-BB4EE929BB6B}")]
	public class SelectManyExercise
	{
		/*

		Вам дан список всех классов в школе. Нужно получить спиок всех учащихся всех классов.
		
		Учебный класс определен так:
		*/

		public class Classroom
		{
			public List<string> Students;
		}

		/*

		Без использования Linq, решение могло бы выглядеть так:
		*/

		[ShowBodyOnSlide]
		public string[] GetAllStudents_NoLinq(Classroom[] classes)
		{
			var allStudents = new List<string>();
			foreach (var classroom in classes)
			{
				foreach (var student in classroom.Students)
				{
					allStudents.Add(student);
				}
			}
			return allStudents.ToArray();
		}

		/*
		Напишите решение этой задачи с помощью Linq в одно выражение.
		*/

		[ExpectedOutput("Pavel\r\nIvan\r\nPetr\r\nAnna\r\nIlya\r\nVladimir\r\nBulat\r\nAlex\r\nGalina")]
		public static void Main()
		{
			Classroom[] classes =
			{
				new Classroom {Students = {"Pavel", "Ivan", "Petr"},},
				new Classroom {Students = {"Anna", "Ilya", "Vladimir"},},
				new Classroom {Students = {"Bulat", "Alex", "Galina"},}
			};
			var allStudents = GetAllStudents(classes);
			foreach (var e in allStudents)
				Console.WriteLine(e);
		}

		[Exercise]
		[Hint("`IEnumerable<R> SelectMany(this IEnumerable<T> items, Func<T, IEnumerable<R>> f)`")]
		[Hint("`T[] ToArray(this IEnumerable<T> items)`")]
		public static string[] GetAllStudents(Classroom[] classes)
		{
			return classes.SelectMany(c => c.Students).ToArray();
		}
	}
}