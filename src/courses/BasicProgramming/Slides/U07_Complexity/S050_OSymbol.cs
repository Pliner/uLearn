﻿namespace uLearn.Courses.BasicProgramming.Slides.U07_Complexity
{
	[Slide("О-символика", "{0A165BD3-2893-447A-B873-75C0BCCAC0C3}")]
	class S050_OSymbol
	{
		//#video HOoYSOdTroU

		/*
		##Заметки по лекции

		###o-малое
	
		$$f(n)=o(g(n)) \Leftrightarrow$$
		$$\forall k>0\ \exists n_0\ \forall n>n_0:\ f(n)<k\cdot g(n) \Leftrightarrow $$
		$$\lim_{n\rightarrow \infty} \frac{f(n)}{g(n)}=0 $$
		$$f(n)\prec g(n) $$

		###O-большое
	
		$$f(n)=O(g(n)) \Leftrightarrow$$
		$$\exists k>0\ \exists n_0\ \forall n>n_0:\ f(n)<k\cdot g(n) \Leftarrow $$
		$$\lim_{n\rightarrow \infty} \frac{f(n)}{g(n)}<\infty $$
		$$f(n)\preceq g(n) $$

		Предел может не существовать, поэтому импликация только в одну сторону. 

		__На видео, импликация ошибочно показана в обе стороны.__

		###Θ-большое
	
		$$f(n)=\Theta(g(n)) \Leftrightarrow $$
		$$\exists k_1,k_2>0\ \exists n_{0}\ \forall n>n_{0}:\ k_1\cdot g(n)<f(n)<k_2 \cdot g(n) \Leftarrow $$
		$$\Leftarrow \lim_{n\rightarrow \infty} \frac{f(n)}{g(n)}=c>0 $$
		$$f(n) \approx g(n) $$

		Предел может не существовать, поэтому импликация только в одну сторону. 
		*/
	}
}
