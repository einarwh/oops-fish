namespace Oops.Svg
{
    public abstract class SvgAttribute
    {
        private readonly string _key;
        private readonly string _value;

        protected SvgAttribute(string key, string value)
        {
            _key = key;
            _value = value;
        }

        public override string ToString()
        {
            return $"{_key}=\"{_value}\"";
        }
    }
}