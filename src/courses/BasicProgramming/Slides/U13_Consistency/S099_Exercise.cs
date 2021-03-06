﻿namespace uLearn.Courses.BasicProgramming.Slides.U13_Consistency
{
	[Slide("Практика", "47BE65D028A64A23A686601ADB85A82E")]
	public class S099_Exercise
	{
		/*
		## Диггер 2

		![Digger 2](digger2.png)

		На этой неделе нужно будет выполнить ещё несколько доработок проекта Диггер с прошлой недели.

		Если задачу на прошлой недели вы сдали менее чем на два балла, то на этой неделе вы можете досдать её 
		до двух баллов, прежде чем приступать к этим задачам.

		### Свойства (1 балл)

		Превратите все поля класса Game в свойства.
		Также превратите в свойства методы GetImageFileName и GetDrawingPriority интерфейса ICreature.
		Защитите целостность класса Game по аналогии с тем, как это делалось в лекциях и соответствующих упражнениях.

		### Статические поля (1 балл)

		Измените класс Game так, чтобы он перестал содержать статические поля.
		Для этого придется сделать следующее:
		
		* статические поля и свойства Game сделайте динамическими.
		* превратите метод Game.CreateMap в конструктор класса Game.
		* DiggerWindow должен будет создать экземпляр класса Game и передавать его во все другие методы, которые ранее использовали статические поля класса Game.

		### Загрузка карты из файла (1 балл)

		Сделайте карту загружаемой из внешнего файла.

		Добавьте в конструктор класса Game параметр — имя файла с описанием начального состояния карты.
		
		Формат файла разработайте самостоятельно так, чтобы его было удобно редактировать в обычном текстовом редакторе.

		Файл с картой включите в проект, и в свойствах файла с картой настройте копирование в выходную директорию (Copy to output directory).
		Так после сборки проекта, файл с картой окажется рядом с exe-файлом Диггера.

		### Творчество (1 балл)
		
		Добавьте в игру Диггер ещё какую-нибудь функциональность на ваше усмотрение!

		*/
	}
}