using System;

namespace 状态模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            context.SetState(new ConcreteStateA(context));

            context.Handle(5);
            context.Handle(20);
            context.Handle(30);
            context.Handle(4);
            context.Handle(6);
        }
    }    

    public class Context
    {
        private IState mState;
        public void SetState(IState state)
        {
            mState = state;
        }

        public void Handle(int arg)
        {
            mState.Handle(arg);
        }
    }

    public interface IState
    {
        void Handle(int arg);
    }

    public class ConcreteStateA : IState
    {
        private Context mContext;
        public ConcreteStateA(Context context)
        {
            mContext = context;
        }

        public void Handle(int arg)
        {
            Console.WriteLine("ConcreateStateA.Handle " + arg);
            if (arg > 10)
            {
                mContext.SetState(new ConcreteStateB(mContext));
            }
        }
    }

    public class ConcreteStateB : IState
    {
        private Context mContext;
        public ConcreteStateB(Context context)
        {
            mContext = context;
        }

        public void Handle(int arg)
        {
            Console.WriteLine("ConcreateStateB.Handle " + arg);
            if (arg <= 10)
            {
                mContext.SetState(new ConcreteStateA(mContext));
            }
        }
    }
}
