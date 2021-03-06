﻿using uLearn;

namespace OOP.Slides.U03_DataStructure
{
	[Slide("Задача. Куча", "{617ADD7C-3093-4B4B-9BDF-E99DA4DB1D11}")]
	public class S040_IHeap
	{
		/*
		Реализуйте max-кучу (бинарную, биномиальную или Фибоначчиеву кучу), где элементами являются целые числа:
		*/

		public interface Heap
		{
			void add(int element);
			int findMax();
			int deleteMax();
		}

		/* 
		Не забудьте протестировать вашу реализацию. В частности, не забудьте про тестирование на больших объемах — вы должны продемонстрировать, что ваша реализация работает эффективно.

		Использовать встроенные в Java коллекции — Map, Set и производные — нельзя, массивы можно.
		*/
	}
}