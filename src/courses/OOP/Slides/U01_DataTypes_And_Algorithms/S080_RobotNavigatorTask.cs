﻿using uLearn;

namespace OOP.Slides.U01_DataTypes_And_Algorithms
{
	[Slide("Задача 'RobotNavigator'", "{81C879D7-984F-4912-9BC1-54F13F87669F}")]
	public class S080_RobotNavigatorTask
	{
		/*
		Создайте класс SimpleNavigator в ОО-стиле, как это было описано на предыдущем слайде.
		
		Реализуйте простейший алгоритм: сначала стоя на месте повернуть робота в направлении целевой точки, затем доехать до нее по прямой.

		Придумайте и реализуйте какой-либо более эффективный алгоритм в классе SmartNavigator.

		Напишите тест, измеряющий эффективность алгоритма на следующих исходных тестовых сценариях:

		Позиция робота				| Направление робота			| Целевая точка	
		----------------------------|-------------------------------|---------------
		(0, 0)						|0.0							|(10, 0)		
		(0, 0)						|0.0							|(-10, 0)		
		(0, 0)						|0.0							|(0, 100)		
		(10, 20)					|0.0							|(10.1, 20.1)	
		(10, 20)					|3.0							|(-100, -20)	
		(0, -10)					|-1.0							|(10, 100)		
		
		Максимальная скорость робота во всех сценариях — 1.0

		Максимальная угловая скорость робота во всех сценариях — 0.05

		Временем считать время, которое понадобилось роботу, чтобы приблизиться к целевой точки на расстояние менее 1e-6.

		Тест должен вывести данную таблицу на консоль, и для каждой строки вывести время SimpleNavigator и время SmartNavigator.

		Чтобы проще было сравнивать алгоритмы, выведите также суммарное время, потраченное на всех сценариях каждым из алгоритмов.
		*/
	}
}