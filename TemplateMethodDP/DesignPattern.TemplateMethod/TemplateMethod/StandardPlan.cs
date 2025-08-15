namespace DesignPattern.TemplateMethod.TemplateMethod
{
    public class StandardPlan : NetflixPlans
    {
        public override void PlanType()
        {
            PlanName = "Standart Plan";
        }

        public override void PersonCount()
        {
            PersonCountValue = 2;
        }

        public override void Price()
        {
            PlanPrice = 124.99;
        }

        public override void Resolution()
        {
            PlanResolution = "1080p";
        }

        public override void Content()
        {
            PlanContent = "Belgesel-Film-Dizi";
        }
    }
}
