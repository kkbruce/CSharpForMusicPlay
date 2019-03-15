<Query Kind="Program">
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main()
{
	Beep((int)Music.Do, 300);
	Beep((int)Music.Do, 300);
	Beep((int)Music.So, 300);
	Beep((int)Music.So, 300);
	Beep((int)Music.La, 300);
	Beep((int)Music.La, 300);
	Beep((int)Music.So, 600);

	Beep((int)Music.Fa, 300);
	Beep((int)Music.Fa, 300);
	Beep((int)Music.Mi, 300);
	Beep((int)Music.Mi, 300);
	Beep((int)Music.Re, 300);
	Beep((int)Music.Re, 300);
	Beep((int)Music.Do, 600);

	Beep((int)Music.So, 300);
	Beep((int)Music.So, 300);
	Beep((int)Music.Fa, 300);
	Beep((int)Music.Fa, 300);
	Beep((int)Music.Mi, 300);
	Beep((int)Music.Mi, 300);
	Beep((int)Music.Re, 600);

	Beep((int)Music.So, 300);
	Beep((int)Music.So, 300);
	Beep((int)Music.Fa, 300);
	Beep((int)Music.Fa, 300);
	Beep((int)Music.Mi, 300);
	Beep((int)Music.Mi, 300);
	Beep((int)Music.Re, 600);

	Beep((int)Music.Do, 300);
	Beep((int)Music.Do, 300);
	Beep((int)Music.So, 300);
	Beep((int)Music.So, 300);
	Beep((int)Music.La, 300);
	Beep((int)Music.La, 300);
	Beep((int)Music.So, 600);

	Beep((int)Music.Fa, 300);
	Beep((int)Music.Fa, 300);
	Beep((int)Music.Mi, 300);
	Beep((int)Music.Mi, 300);
	Beep((int)Music.Re, 300);
	Beep((int)Music.Re, 300);
	Beep((int)Music.Do, 600);
}

// Define other methods and classes here
[DllImport("kernel32.dll")]
private static extern int Beep(int dwFreq, int dwDuration);

public enum Music
{
	Do = 523,
	Re = 587,
	Mi = 659,
	Fa = 698,
	So = 784,
	La = 880,
	Ti = 988,
	Do2 = 1046
}