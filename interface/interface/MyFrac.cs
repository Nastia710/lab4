using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public class MyFrac : IMyNumber<MyFrac>, IComparable<MyFrac>
{
    BigInteger nom;
    BigInteger denom;

    public MyFrac(BigInteger nom, BigInteger denom)
    {
        if (denom == 0)
        {
            throw new DivideByZeroException();
        }

        bool sing = true;

        if (nom * denom <= 0)
        {
            sing = false;
        }

        this.nom = nom;
        this.denom = denom;

        FractionalReduction();

        if (sing == false)
        {
            this.nom *= -1;
        }
    }

    public MyFrac(MyFrac myFrac)
    {
        this.nom = myFrac.nom;
        this.denom = myFrac.denom;
        
        if (denom == 0)
        {
            throw new DivideByZeroException();
        }
    }

    public MyFrac(int nom, int denom)
    {
        if (denom == 0)
        {
            throw new DivideByZeroException();
        }

        bool sing = true;

        if (nom * denom <= 0)
        {
            sing = false;
        }
        
        this.nom = nom;
        this.denom = denom;

        FractionalReduction();

        if (sing == false)
        {
            this.nom *= -1;
        }
    }

    public void FractionalReduction()
    {
        var nom = Math.Abs((int)this.nom);
        var denom = Math.Abs((int)this.denom);

        BigInteger gcd = BigInteger.GreatestCommonDivisor(nom, denom);

        this.nom = nom / gcd;
        this.denom = denom / gcd;
    }

    public MyFrac Add(MyFrac that)
    {
        BigInteger ad = this.nom * that.denom;
        BigInteger bc = this.denom * that.nom;
        BigInteger bd = this.denom * that.denom;

        return new MyFrac(ad + bc, bd);
    }

    public MyFrac Subtract(MyFrac that)
    {
        BigInteger ad = this.nom * that.denom;
        BigInteger bc = this.denom * that.nom;
        BigInteger bd = this.denom * that.denom;

        return new MyFrac(ad - bc, bd);
    }

    public MyFrac Multiply(MyFrac that)
    {
        BigInteger ac = this.nom * that.nom;
        BigInteger bd = this.denom * that.denom;

        return new MyFrac(ac, bd);
    }

    public MyFrac Divide(MyFrac that)
    {
        if (that.nom == 0)
        {
            throw new DivideByZeroException();
        }

        BigInteger ad = this.nom * that.denom;
        BigInteger bc = this.denom * that.nom;

        return new MyFrac(ad, bc);
    }

    override public String ToString()
    {
        if (denom == 1)
        {
            return $"{nom}";
        }
        return $"{nom}/{denom}";
    }

    public int CompareTo(MyFrac that)
    {
        BigInteger nom1 = this.nom * that.denom;
        BigInteger nom2 = that.nom * this.denom;

        return nom1.CompareTo(nom2);
    }
}

