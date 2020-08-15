#define ObserverAndDelegate
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
#if ObserverAndDelegate //使用观察者模式
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject1 sub1 = new ConcreteSubject1();

            ConcreteObserver1 ob1 = new ConcreteObserver1(sub1);
            ConcreteObserver2 ob2 = new ConcreteObserver2(sub1);

            //观察者要执行的方法委托给发布者的更新方法上
            sub1.Update += new EventHandler(ob1.MyUpdate);
            sub1.Update += new EventHandler(ob2.Update);

            sub1.SubjectState = "温度 90";
            //sub1.Notify();
            Console.ReadLine();
        }
    }
    //通知者类，给具体观察者提供接口
    interface ISubject
    {

        void Notify();
        string SubjectState
        {
            get;
            set;
        }
    }
    //声明一个委托（事件处理程序）
    public delegate void EventHandler();

    //具体主题类
    public class ConcreteSubject1 : ISubject
    {
        //声明一事件Update,类型为委托EventHandler
        public event EventHandler Update;

        private string mSubjectState;
        public string SubjectState
        {
            set
            {
                mSubjectState = value;
                Notify();
            }
            get { return mSubjectState; }
        }

        public void Notify()
        {
            Update();
        }


    }

    public abstract class Observer
    {
        public abstract void Update();
    }

    //观察者1
    public class ConcreteObserver1 : Observer
    {
        public ConcreteSubject1 mSub;
        public ConcreteObserver1(ConcreteSubject1 sub)
        {
            mSub = sub;
        }
        public override void Update()
        {
            Console.WriteLine("Oberser1更新显示" + mSub.SubjectState);
        }

        public void MyUpdate()
        {
            Console.WriteLine("Oberser1不想更新显示" + mSub.SubjectState);
        }
    }
    //观察2
    public class ConcreteObserver2 : Observer
    {
        public ConcreteSubject1 mSub;
        public ConcreteObserver2(ConcreteSubject1 sub)
        {
            mSub = sub;
        }
        public override void Update()
        {
            Console.WriteLine("Oberser2更新显示" + mSub.SubjectState);
        }
    }
#else
#endif
}
