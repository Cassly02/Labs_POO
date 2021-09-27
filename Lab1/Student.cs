using System;

public class Student //o clasa student
{
    private string namest;
    private int age;

	/*public getName()
    {
		return this.namest;
    }*/
	private float mark; //se poate modifica in corpul clasei Student
	public Student(string aNameSt, int aAgeSt, float aMarkSt) //constructorul
	{
		namest = aNameSt;
		age = aAgeSt;
        Mark = aMarkSt;		//setam nota in din mark->Mark in corespondenta cu setter-ul de mai jos (Mark apeleaza setterul)
	}
	public float Mark	//proprietatea  
    {
        get
        {
			return mark;
        }
        set //modificarea - ne permite (putem seta careva reguli)
        {
			mark = value;
        }
    }
	public string Namest
    {
        get { return namest; }
        set { namest = value; }
    }
    public int Age
    {
        get { return age;}
        set { age = value;}
    }
    /*
      public float getMark()
    {
        return this.mark;
    }
    */
}
