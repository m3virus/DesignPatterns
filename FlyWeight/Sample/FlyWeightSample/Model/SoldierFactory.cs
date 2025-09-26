namespace FlyWeightSample.Model
{
    public class SoldierFactory
    {
        private Dictionary<string, SoldierType> _soldierTypes = new();
        public SoldierType GetSoldierType(string model, string texture)
        {
            string key = model + texture;
            if (!_soldierTypes.ContainsKey(key))
            {
                _soldierTypes[key] = new SoldierType(model, texture);
            }
            return _soldierTypes[key];
        }
    }
}
