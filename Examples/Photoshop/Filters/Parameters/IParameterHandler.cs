namespace MyPhotoshop.Filters.Parameters
{
    public interface IParameterHandler<TParameters>
    {
        ParameterInfo[] GetDescription();
        TParameters CreateParameters(double[] values);

    }
}