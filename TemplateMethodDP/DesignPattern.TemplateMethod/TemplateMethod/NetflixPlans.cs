namespace DesignPattern.TemplateMethod.TemplateMethod
{
    public abstract class NetflixPlans
    {
        public string PlanName { get; set; }
        public int PersonCountValue { get; set; }
        public double PlanPrice { get; set; }
        public string PlanResolution { get; set; }
        public string PlanContent { get; set; }

        public void CreatePlan()
        {
            PlanType();
            PersonCount();
            Price();
            Resolution();
            Content();
        }

        public abstract void PlanType();
        public abstract void PersonCount();
        public abstract void Price();
        public abstract void Resolution();
        public abstract void Content();
    }
}
