
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Pizza {

    public Pizza() {
    }

    public String name;

    /// <summary>
    /// @return
    /// </summary>
    public void Bake() {
        // TODO implement here
        Console.WriteLine("烘焙");
    }

    /// <summary>
    /// @return
    /// </summary>
    public void Box() {
        // TODO implement here
        Console.WriteLine("打包");
    }

    /// <summary>
    /// @return
    /// </summary>
    public void Cut() {
        // TODO implement here
        Console.WriteLine("切块");
    }

    /// <summary>
    /// @return
    /// </summary>
    public abstract void Prepare();
    //{
    //    // TODO implement here
    //    //Console.WriteLine("准备辅料");
    //}
}