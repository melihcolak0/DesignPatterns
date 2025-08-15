namespace DesignPattern.TemplateMethod.TemplateMethod
{
    public class UltraPlan : NetflixPlans
    {
        public override void PlanType()
        {
            PlanName = "Ultra Plan";
        }

        public override void PersonCount()
        {
            PersonCountValue = 4;
        }

        public override void Price()
        {
            PlanPrice = 254.99;
        }

        public override void Resolution()
        {
            PlanResolution = "4k";
        }

        public override void Content()
        {
            PlanContent = "Belgesel-Film-Dizi-İnteraktif";
        }
    }
}
