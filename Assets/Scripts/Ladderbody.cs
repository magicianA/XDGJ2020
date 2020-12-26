using UnityEngine;

namespace PC2D
{
    public class Ladderbody : SpriteDebug
    {
        public bool enableRestrictedArea = true;
        public SpriteRenderer restrictedArea = null;
        public bool disableRestrictedTop = true;
        public float topHeight = 0;
        public float bottomHeight = 0;
        private Ladder ladder;
        public override void Start()
        {
            base.Start();
            ladder = transform.parent.GetComponent<Ladder>();
        }
        public override void OnTriggerEnter2D(Collider2D o)
        {
            base.OnTriggerEnter2D(o);

            PlatformerMotor2D motor = o.GetComponent<PlatformerMotor2D>();
            if (motor && ladder.bugType != 1 && ladder.bugType != 2)
            {
                // some games could want to enable auto bottom/top detection based on
                // restricted area... restrictedArea ? restrictedArea.bounds : _sprite.bounds
                motor.LadderAreaEnter(_sprite.bounds, topHeight, bottomHeight);

                if (enableRestrictedArea)
                {
                    motor.SetRestrictedArea(restrictedArea.bounds, disableRestrictedTop);
                }
                else
                {
                    motor.ClearRestrictedArea();
                }
            }
        }

        public override void OnTriggerStay2D(Collider2D o)
        {
            base.OnTriggerStay2D(o);

            PlatformerMotor2D motor = o.GetComponent<PlatformerMotor2D>();
            if (motor && ladder.bugType != 1 && ladder.bugType != 2)
            {
                motor.LadderAreaEnter(_sprite.bounds, topHeight, bottomHeight);
            }
        }

        public override void OnTriggerExit2D(Collider2D o)
        {
            base.OnTriggerExit2D(o);

            PlatformerMotor2D motor = o.GetComponent<PlatformerMotor2D>();
            if (motor && ladder.bugType != 1 && ladder.bugType != 2)
            {
                motor.FreedomAreaExit();
                if (enableRestrictedArea)
                {
                    motor.DisableRestrictedArea();
                    motor.ClearRestrictedArea();
                }
            }
        }
    }
}
