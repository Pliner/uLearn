﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace uLearn.Courses.Linq.Slides
{
	[Slide("Декартово произведение", "{FF3215D3-5CC7-4C28-83B1-77465F570DC8}")]
	public class CartesianProduct
	{
		/*

		Одно из не совсем очевидных применений `SelectMany` — это вычисление декартова произвдеения двух множеств.
		Опробуйте этот трюк на следующей задаче:

		Вычислить множество всех соседей заданной точки в смысле 8-связности.

		*/
		
		[ExpectedOutput("True")]
		public static void Main()
		{
			var answer = GetNeighbours(new Point(1, 2));
			Console.WriteLine(IsRightCartesian(answer));
		}

		[Exercise(SingleStatement = false)]
		[Hint("Декартово произведение множества {-1, 0, 1} на себя даст все возможные относительные координаты соседей")]
		[Hint("Используйте вызов Select внутри вызова SelectMany")]
		[Hint("Метода ToHashSet не существует, однако у класса HashSet<T> есть конструктор, принимающий последовательность")]
		public static HashSet<Point> GetNeighbours(Point p)
		{
			int[] d = {-1, 0, 1};
			return new HashSet<Point>(
				d
					.SelectMany(dx => d.Select(dy => new Point(p.X + dx, p.Y + dy)))
					.Where(n => !n.Equals(p))
				);
			/*uncomment
			int[] d = {-1, 0, 1};
			return ...
			*/
		}

		[HideOnSlide]
		public static bool IsRightCartesian(IEnumerable<Point> neighbours)
		{
			var correctAnswer = new HashSet<Point>()
			{
				new Point(0, 1),
				new Point(0, 2),
				new Point(0, 3),
				new Point(1, 1),
				new Point(1, 3),
				new Point(2, 1),
				new Point(2, 2),
				new Point(2, 3)
			};
			return neighbours.All(correctAnswer.Contains);
		}

		[HideOnSlide]
		public class Point
		{
			[HideOnSlide]
			public Point(int x, int y)
			{
				X = x;
				Y = y;
			}
			[HideOnSlide]
			public int X, Y;

			[HideOnSlide]
			public override string ToString()
			{
				return string.Format("X: {0}, Y: {1}", X, Y);
			}

			[HideOnSlide]
			protected bool Equals(Point other)
			{
				return X == other.X && Y == other.Y;
			}

			[HideOnSlide]
			public override bool Equals(object obj)
			{
				if (ReferenceEquals(null, obj)) return false;
				if (ReferenceEquals(this, obj)) return true;
				if (obj.GetType() != this.GetType()) return false;
				return Equals((Point)obj);
			}

			[HideOnSlide]
			public override int GetHashCode()
			{
				unchecked
				{
					return (X * 397) ^ Y;
				}
			}
		}

	}
}