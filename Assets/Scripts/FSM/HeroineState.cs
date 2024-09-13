using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface HeroineState
{
    public virtual void handleInput(Heroine heroine, Input input) { }
    public virtual void update(Heroine heroine) { }
};
