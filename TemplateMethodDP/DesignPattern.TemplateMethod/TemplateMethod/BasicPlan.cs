namespace DesignPattern.TemplateMethod.TemplateMethod
{
    public class BasicPlan : NetflixPlans
    {
        public override void PlanType()
        {
            PlanName = "Temel Plan";
        }

        public override void PersonCount()
        {
            PersonCountValue = 1;
        }

        public override void Price()
        {
            PlanPrice = 65.99;
        }

        public override void Resolution()
        {
            PlanResolution = "480p";
        }

        public override void Content()
        {
            PlanContent = "Film-Dizi";
        }
    }
}
