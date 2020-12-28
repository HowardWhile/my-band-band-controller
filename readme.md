

# ON_OFF_Controller.cs



## Example

### General on-off control output

![On-off control output](pic/readme/On-off-control-output-283x300.png)

```c#
ON_OFF_Controller_general generl_ctrl = new ON_OFF_Controller_general();
int OnOff = generl_ctrl.Update_Once(this.tbar_setpoint.Value, this.plant_feedback);

if (OnOff == 1)
    this.controller_output += gain;
if (OnOff == 0)
    this.controller_output -= gain;
```

### On-off control with hysteresis output

![On-off control with hysteresis output](pic/readme/On-off-control-with-hysteresis-output-287x300.png)





# _ (┐「ε:) _

