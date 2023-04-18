using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace model_starter_new
{
        public interface IFollowable
        {
            /// <summary>
            /// The IFollowable's position in the world 
            /// </summary>
            Vector3 Position { get; }

            /// <summary>
            /// The angle the IFollowable is facing, in radians 
            /// </summary>
            float Facing { get; }
        }
}
