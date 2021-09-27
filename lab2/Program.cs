using System;

namespace POOLab2
{
    public class box
    {

        private int height;
        private int width;
        private int depth;

        public box()
        {
            height = 1;
            width = 1;
            depth = 1;
        }
        public int getHeight(){return this.height;}
        public int getWidth() { return this.width; }
        public int getDepth() { return this.depth; }
        public void setHeight(int height) { this.height = height; }
        public void setWidth(int width) { this.width = width; }
        public void setDepth(int depth) { this.depth = depth; }



        public box(int val)
        {
            height = val;
            width = val;
            depth = val;
        }

        public box(int height, int width, int depth)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;
        }

        public double getArea()
        {
            return (2 * depth * width + 2 * depth * height + 2 * height * width);
        }

        public double getVol()
        {
            return (height * width * depth);
        }

        public string showRes()
        {
            return ("\nHeight: " + height + "\nWidth: " + width + "\nDepth: " + depth);
        }
    }
    public class Queue
    {
        private int capacity;
        private int[] queue;
        private int front;
        private int back;
        private int count;

        public int geCapacityt() { return this.capacity; }
        public int[] getQueue() { return this.queue; }
        public int getFront() { return this.front; }
        public int getBack() { return this.back; }
        public int getcount() { return this.count; }

        public void setCapacity(int capacity) { this.capacity = capacity; }
        public void setQueue(int[] queue) { this.queue = queue; }
        public void setFront(int front) { this.front = front; }
        public void setBack(int back) { this.back = back; }
        public void setCount(int count) { this.count = count; }

        public Queue(int size)
        {
            capacity = size;
            queue = new int[capacity];
            front = 0;
            back = -1;
            count = 0;
        }

        public Queue()
        {
            capacity = 50;
            queue = new int[50];
            front = 0;
            back = 0;
            count = 0;

        }

        public void push(int add)
        {
            Console.WriteLine("Insert: " + add);
            if (back == capacity - 1)
                back = -1;
            queue[++back] = add;
            count++;
        }


        public int pop()
        {
            int temp = queue[front++];
            if (front == capacity)
                front = 0;
            count--;
            return temp;
        }

        public void isEmpty()
        {

            if (count == 0)
            {
                Console.WriteLine("Queue is empty.");
            }
        }

        public void isFull()
        {
            if (capacity == size()){Console.WriteLine("*Our Queue is already full*");}
            else{ Console.WriteLine("*Our Queue has elements but it's not full");}
        }

        public int size()
        {
            return count+1;
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("!!!Basic Level:!!!");

            box b1 = new box();
            box b2 = new box(355);
            box b3 = new box(13, 43, 21);

            Console.WriteLine("\nFirst box :");

            Console.WriteLine("Box's size: " + b1.showRes());
            Console.WriteLine("Box's surface area: " + b1.getArea() + " cm2");
            Console.WriteLine("Box's volume: " + b1.getVol() + " cm3");

            Console.WriteLine("-------------------");

            Console.WriteLine("\n Second box:");
            Console.WriteLine("Box's size: " + b2.showRes());
            Console.WriteLine("Box's surface area: " + b2.getArea() + " cm2");
            Console.WriteLine("Box's volume: " + b2.getVol() + " cm3");

            Console.WriteLine("-------------------");

            Console.WriteLine("\nThird box");
            Console.WriteLine("Box's size: " + b3.showRes());
            Console.WriteLine("Box's surface area: " + b3.getArea() + " cm2");
            Console.WriteLine("Box's volume: " + b3.getVol() + " cm3");
            Console.WriteLine("-------------------");


            Console.WriteLine("\n!!!Advanced Levels:!!!");

            Queue q1 = new Queue(5);
            Queue q2 = new Queue();

            Console.WriteLine("\nFirst queue:");
            q1.push(46);
            q1.push(234);
            q1.push(76);

            q1.pop();
            q1.isEmpty();
            q1.isFull();

            Console.WriteLine("The queue has " + q1.size() + " elements.");

            Console.WriteLine("\nSecond queue:");
            q2.push(65);
            q2.push(24);
            q2.push(564);

            q2.pop();
            q2.isEmpty();
            q2.isFull();

            Console.WriteLine("The queue has " + q2.size() + " elements.");
        }

    }

}
