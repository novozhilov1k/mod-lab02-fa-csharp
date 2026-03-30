using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fans
{
  public class State
  {
    public string Name;
    public Dictionary<char, State> Transitions;
    public bool IsAcceptState;
  }


  public class FA1
  {
    //s0 начало, s1 есть 1 но нет 0, s2 есть 0 нет 1, s3 есть оба, s4 2 или больше нуля
    public static State s0 = new State()
    {
      Name = "s0",
      IsAcceptState = false,
      Transitions = new Dictionary<char, State>()
    };
    public State s2 = new State()
    {
      Name = "s2",
      IsAcceptState = false,
      Transitions = new Dictionary<char, State>()
    };
    public State s1 = new State()
    {
      Name = "s1",
      IsAcceptState = false,
      Transitions = new Dictionary<char, State>()
    };
    public State s3 = new State()
    {
      Name = "s3",
      IsAcceptState = true,
      Transitions = new Dictionary<char, State>()
    };
    public State s4 = new State()
    {
      Name = "s4",
      IsAcceptState = false,
      Transitions = new Dictionary<char, State>()
    };
    State InitialState = s0;
    public FA1()
    {
      s0.Transitions['0'] = s2;
      s0.Transitions['1'] = s1;

      s1.Transitions['0'] = s3;
      s1.Transitions['1'] = s1;

      s2.Transitions['1'] = s3;
      s2.Transitions['0'] = s4;

      s3.Transitions['0'] = s4;
      s3.Transitions['1'] = s3;

      s4.Transitions['0'] = s4;
      s4.Transitions['1'] = s4;
    }
    public bool? Run(IEnumerable<char> s)
    {
      State cur = InitialState;
      foreach(shar ss in s)
      {
        if(ss != "1" && ss != "0")
        {
          return null;
        }

        if (!current.Transitions.ContainsKey(c)) return null;

        cur = cur.Transitions[ss];
      }

      return cur.IsAcceptState;
    }
  }

  public class FA2
  {
    public static State s0 = new State()
    {
      Name = "s0",
      IsAcceptState = false,
      Transitions = new Dictionary<char, State>()
    };
     public State s1 = new State()
    {
      Name = "s1",
      IsAcceptState = false,
      Transitions = new Dictionary<char, State>()
    };
    public State s2 = new State()
    {
      Name = "s2",
      IsAcceptState = false,
      Transitions = new Dictionary<char, State>()
    };
    public State s3 = new State()
    {
      Name = "s3",
      IsAcceptState = true,
      Transitions = new Dictionary<char, State>()
    };
    public State s4 = new State()
    {
      Name = "s4",
      IsAcceptState = false,
      Transitions = new Dictionary<char, State>()
    };
    public State s5 = new State()
    {
      Name = "s5",
      IsAcceptState = false,
      Transitions = new Dictionary<char, State>()
    };
    public State s6 = new State()
    {
      Name = "s6",
      IsAcceptState = false,
      Transitions = new Dictionary<char, State>()
    };
    State InitialState = s0;

    //s0 - начало, s1 первая/нечетное кол 1, s2 первая/нечетное кол 0, s3 все ок оба подходят, 
    //s4 нечетное 1 четное 0, s5 четное 1 нечетное 0, s6 оба четные 
    public FA2()
    {
      s0.Transitions['0'] = s2;
      s0.Transitions['1'] = s1;

      s1.Transitions['0'] = s3;
      s1.Transitions['1'] = s0;

      s2.Transitions['1'] = s3;
      s2.Transitions['0'] = s0;

      s3.Transitions['0'] = s4;
      s3.Transitions['1'] = s5;

      s4.Transitions['0'] = s3;
      s4.Transitions['1'] = s6;

      s5.Transitions['0'] = s6;
      s5.Transitions['1'] = s3;

      s6.Transitions['0'] = s5;
      s6.Transitions['1'] = s4;
    }
    public bool? Run(IEnumerable<char> s)
    {
      State cur = InitialState;
      foreach(shar ss in s)
      {
        if(ss != "1" && ss != "0")
        {
          return null;
        }

        if (!current.Transitions.ContainsKey(c)) return null;

        cur = cur.Transitions[ss];
      }

      return cur.IsAcceptState;
    }
  }
  
  public class FA3
  {
    public static State s0 = new State()
    {
      Name = "s0",
      IsAcceptState = false,
      Transitions = new Dictionary<char, State>()
    };
     public State s1 = new State()
    {
      Name = "s1",
      IsAcceptState = false,
      Transitions = new Dictionary<char, State>()
    };
    public State s2 = new State()
    {
      Name = "s2",
      IsAcceptState = true,
      Transitions = new Dictionary<char, State>()
    };
    State InitialState = s0;
    //s0 старт/последний был 0, s1 первая 1, s2 11 встретилось 
    public FA3()
    {
      s0.Transitions['0'] = s0;
      s0.Transitions['1'] = s1;

      s1.Transitions['0'] = s0;
      s1.Transitions['1'] = s2;
      
      s2.Transitions['0'] = s2;
      s2.Transitions['1'] = s2;
      
    }

    public bool? Run(IEnumerable<char> s)
    {
      State cur = InitialState;
      foreach(shar ss in s)
      {
        if(ss != "1" && ss != "0")
        {
          return null;
        }

        if (!current.Transitions.ContainsKey(c)) return null;

        cur = cur.Transitions[ss];
      }

      return cur.IsAcceptState;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      String s = "01111";
      FA1 fa1 = new FA1();
      bool? result1 = fa1.Run(s);
      Console.WriteLine(result1);
      FA2 fa2 = new FA2();
      bool? result2 = fa2.Run(s);
      Console.WriteLine(result2);
      FA3 fa3 = new FA3();
      bool? result3 = fa3.Run(s);
      Console.WriteLine(result3);
    }
  }
}