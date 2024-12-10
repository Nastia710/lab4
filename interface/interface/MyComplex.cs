using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

public class MyComplex: IMyNumber<MyComplex>
{
    double re;
    double im;

    public MyComplex(double re, double im)
    {
        this.re = re;
        this.im = im;
    }

    public MyComplex(MyComplex myComplex)
    {
        this.re = myComplex.re;
        this.im = myComplex.im;
    }

    public MyComplex Add(MyComplex that)
    {
        return new MyComplex(this.re + that.re, this.im + that.im);
    }

    public MyComplex Subtract(MyComplex that)
    {
        return new MyComplex(this.re - that.re, this.im - that.im);
    }

    public MyComplex Multiply(MyComplex that)
    {
        double ac = (this.re * that.re);
        double bd = (this.im * that.im);
        double ad = (this.re * that.im);
        double bc = (this.im * that.re);
        
        return new MyComplex(ac - bd, ad + bc);
    }

    public MyComplex Divide(MyComplex that)
    {
        double denom = Math.Pow(that.re, 2) + Math.Pow(that.im, 2);

        if (denom == 0)
        {
            throw new DivideByZeroException();
        }

        double ac = (this.re * that.re);
        double bd = (this.im * that.im);
        double ad = (this.re * that.im);
        double bc = (this.im * that.re);

        return new MyComplex((ac + bd)/denom, (bc - ad)/denom);
    }

    override public String ToString()
    {
        /*if (re == 0)
        {
            return ($"{im}i or 0{im}i");
        }*/

        if (im >= 0)
        {
            return($"{re}+{Math.Abs(im)}i");
        }
        
        /*if(im == 0)
        {
            return ($"{re} or {re}+0i");
        }

        if (im == 1)
        {
            return ($"{re} or {re}+i");
        }

        if (im == -1)
        {
            return ($"{re} or {re}-i");
        }*/

        else
        {
            return ($"{re}-{Math.Abs(im)}i");
        }
    }
}

