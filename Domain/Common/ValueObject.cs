namespace Domain.Common;

public abstract class ValueObject : IEquatable<ValueObject>
{
    public abstract bool PropertiesAreEqual(ValueObject other);
    public abstract int PropertiesHashCode();

    public static bool operator ==(ValueObject? obj1, ValueObject? obj2)
    {
        return (obj1 == null && obj2 == null)
            || obj1?.Equals(obj2) == true;
    }

    public static bool operator !=(ValueObject? obj1, ValueObject? obj2)
    {
        return !(obj1 == obj2);
    }

    public bool Equals(ValueObject? other)
    {
        return Equals(other as object);
    }

    public override bool Equals(object? obj)
    {
        return obj is ValueObject other
            && PropertiesAreEqual(other);
    }

    public override int GetHashCode()
    {
        return PropertiesHashCode();
    }
}
