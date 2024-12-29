namespace Part2
{
    public class CustomObject
    {
        private int id;
        private string name;

        public CustomObject(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return $" Object [ ID : {id}, Name : {name} ]";
        }

        // public override bool Equals(object obj)
        // {
        //     CustomObject customObject = obj as CustomObject;
        //     if (customObject != null)
        //     {
        //         if (customObject.name == this.name && customObject.id == this.id)
        //         {
        //             return true;
        //         }
        //     }
        //     return false;
        // }
        public static bool operator ==(CustomObject customObject1, CustomObject customObject2)
        {
            if (!customObject1.Equals(null) && !customObject2.Equals(null))
            {
                if (customObject1.id.Equals(customObject2.id) && customObject1.name.Equals(customObject2.name)) { return true; }
            }
            return false;
        }

        public static bool operator !=(CustomObject customObject1, CustomObject customObject2)
        {
            if (!customObject1.Equals(null) && !customObject2.Equals(null))
            {
                if (!customObject1.id.Equals(customObject2.id) || !customObject1.name.Equals(customObject2.name)) { return true; }
            }
            return false;
        }

    }
}