using static System.Console;


class Parent
{   
    /*
    Notes on constructors.
    When creating a object child, it will first run the constructor on the Parent:(if parent set pubA=1 and child set pubA=2, we want the value set by the child, else the value would be 1.)


    */

    public int PubA; // Public wil be avaialble to child class 
    private int PriA;
    protected int ProA; // Protected wil be avaialble to child class

    public Parent()
    {
        PubA = 1; // child constructor wil overWrite this value if set by the child constructor
    }
    public Parent(int pubA, int priA, int proA)
    {
        PubA= pubA;
        PriA= priA;
        ProA = proA;

    }

    

}

// Protected is public in CHILD/DERIVED CLASSES, and private in other classes.
// Private is Private for every class, including derived classes.

class Child : Parent
{
    public int PubB;

    public Child(int priA, int proA, int pubA, int pubB)
        :base(priA, proA, pubA)
    {
        //PriA = priA
        ProA = proA;
        PubA = pubA;
        PubB = pubB;
    }




    public void Whatever()
    {
        PubA = 1;
        ProA= 2; // child wil have access to Parent protected (Only if trying to access from "WITHIN" the derived class) NOT from the outside !.
        //PriA = 2; // Nope
        //PriA = 2; // Nope

        Child child_c = new Child(1, 2, 3, 4);
        child_c.PubA = 2; // new child sees Parent Public PubA;

        Parent p1 = new Parent();
        p1.PubA = 3; // new Parent sees its own public.

        //p1.PriA = 4; // new Parent cant see its own private!.

        this.ProA = 5; // current object "child" can see Parent protected ProA;

    }

}
