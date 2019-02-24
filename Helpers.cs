using UnityEngine;

 class Helpers 
{
    public static class Anim
    {

        public static float easeInQuad(float t)
        {
            return t * t;
        }
        public static float easeOutQuad(float t)
        {
            return t * (2 - t);
        }
        public static float easeInOutQuad(float t)
        {
            return t < .5 ? 2 * t * t : -1 + (4 - 2 * t) * t;
        }
        public static float easeInCubic(float t)
        {
            return t * t * t;
        }
        public static float easeOutCubic(float t)
        {
            return (--t) * t * t + 1;
        }
        public static float easeInOutCubic(float t)
        {
            return t < .5 ? 4 * t * t * t : (t - 1) * (2 * t - 2) * (2 * t - 2) + 1;
        }
        public static float easeInQuart(float t)
        {
            return t * t * t * t;
        }
        public static float easeOutQuart(float t)
        {
            return 1 - (--t) * t * t * t;
        }
        public static float easeInOutQuart(float t)
        {
            return t < .5 ? 8 * t * t * t * t : 1 - 8 * (--t) * t * t * t;
        }
        public static float easeInQuint(float t)
        {
            return t * t * t * t * t;
        }
        public static float easeOutQuint(float t)
        {
            return 1 + (--t) * t * t * t * t;
        }
        public static float easeInOutQuint(float t)
        {
           
            return t < .5 ? 16 * t * t * t * t * t : 1 + 16 * (--t) * t * t * t * t;
        }
        public static float easeInExpo(float t)
        {
            return t == 0 ? 0 : (float)Mathf.Pow(2, 10 * (t-1));
        }
        public static float easeOutExpo(float t)
        {
            return t == 1 ? 1 : (-(float)Mathf.Pow(2, -10 * t) + 1);
        }


    }
}
