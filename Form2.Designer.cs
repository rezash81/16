namespace AGaugeApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.mediaplayerr = new AxWMPLib.AxWindowsMediaPlayer();
            this.aGauge11 = new AGaugeApp.AGauge();
            this.Gauge_pressure = new System.Windows.Forms.AGauge();
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayerr)).BeginInit();
            this.SuspendLayout();
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            this.aGauge1.Location = new System.Drawing.Point(437, 277);
            this.aGauge1.MaxValue = 400F;
            this.aGauge1.MinValue = -100F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 50F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(205, 180);
            this.aGauge1.TabIndex = 17;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // mediaplayerr
            // 
            this.mediaplayerr.Enabled = true;
            this.mediaplayerr.Location = new System.Drawing.Point(256, 24);
            this.mediaplayerr.Name = "mediaplayerr";
            this.mediaplayerr.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaplayerr.OcxState")));
            this.mediaplayerr.Size = new System.Drawing.Size(302, 135);
            this.mediaplayerr.TabIndex = 18;
            // 
            // aGauge11
            // 
            this.aGauge11.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge11.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge11.BaseArcRadius = 40;
            this.aGauge11.BaseArcStart = -90;
            this.aGauge11.BaseArcSweep = 360;
            this.aGauge11.BaseArcWidth = 2;
            this.aGauge11.Cap_Idx = ((byte)(1));
            this.aGauge11.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge11.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge11.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge11.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge11.CapText = "";
            this.aGauge11.Center = new System.Drawing.Point(70, 70);
            this.aGauge11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge11.Location = new System.Drawing.Point(282, 165);
            this.aGauge11.MaxValue = 10F;
            this.aGauge11.MinValue = 0F;
            this.aGauge11.Name = "aGauge11";
            this.aGauge11.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.aGauge11.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge11.NeedleRadius = 40;
            this.aGauge11.NeedleType = 0;
            this.aGauge11.NeedleWidth = 10;
            this.aGauge11.Range_Idx = ((byte)(0));
            this.aGauge11.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge11.RangeEnabled = false;
            this.aGauge11.RangeEndValue = 300F;
            this.aGauge11.RangeInnerRadius = 70;
            this.aGauge11.RangeOuterRadius = 80;
            this.aGauge11.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge11.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge11.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge11.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge11.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge11.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge11.RangeStartValue = -100F;
            this.aGauge11.ScaleLinesInterColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.aGauge11.ScaleLinesInterInnerRadius = 42;
            this.aGauge11.ScaleLinesInterOuterRadius = 50;
            this.aGauge11.ScaleLinesInterWidth = 1;
            this.aGauge11.ScaleLinesMajorColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.aGauge11.ScaleLinesMajorInnerRadius = 40;
            this.aGauge11.ScaleLinesMajorOuterRadius = 50;
            this.aGauge11.ScaleLinesMajorStepValue = 1F;
            this.aGauge11.ScaleLinesMajorWidth = 2;
            this.aGauge11.ScaleLinesMinorColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.aGauge11.ScaleLinesMinorInnerRadius = 43;
            this.aGauge11.ScaleLinesMinorNumOf = 1;
            this.aGauge11.ScaleLinesMinorOuterRadius = 50;
            this.aGauge11.ScaleLinesMinorWidth = 1;
            this.aGauge11.ScaleNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.aGauge11.ScaleNumbersFormat = null;
            this.aGauge11.ScaleNumbersRadius = 62;
            this.aGauge11.ScaleNumbersRotation = 0;
            this.aGauge11.ScaleNumbersStartScaleLine = 2;
            this.aGauge11.ScaleNumbersStepScaleLines = 2;
            this.aGauge11.Size = new System.Drawing.Size(149, 148);
            this.aGauge11.TabIndex = 16;
            this.aGauge11.Text = "aGauge11";
            this.aGauge11.Value = 0F;
            // 
            // Gauge_pressure
            // 
            this.Gauge_pressure.BaseArcColor = System.Drawing.Color.Gray;
            this.Gauge_pressure.BaseArcRadius = 80;
            this.Gauge_pressure.BaseArcStart = 135;
            this.Gauge_pressure.BaseArcSweep = 270;
            this.Gauge_pressure.BaseArcWidth = 2;
            this.Gauge_pressure.Center = new System.Drawing.Point(100, 100);
            this.Gauge_pressure.Location = new System.Drawing.Point(62, 250);
            this.Gauge_pressure.MaxValue = 1051F;
            this.Gauge_pressure.MinValue = 749F;
            this.Gauge_pressure.Name = "Gauge_pressure";
            this.Gauge_pressure.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.Gauge_pressure.NeedleColor2 = System.Drawing.Color.Lime;
            this.Gauge_pressure.NeedleRadius = 80;
            this.Gauge_pressure.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.Gauge_pressure.NeedleWidth = 2;
            this.Gauge_pressure.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.Gauge_pressure.ScaleLinesInterInnerRadius = 73;
            this.Gauge_pressure.ScaleLinesInterOuterRadius = 80;
            this.Gauge_pressure.ScaleLinesInterWidth = 1;
            this.Gauge_pressure.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.Gauge_pressure.ScaleLinesMajorInnerRadius = 70;
            this.Gauge_pressure.ScaleLinesMajorOuterRadius = 80;
            this.Gauge_pressure.ScaleLinesMajorStepValue = 50F;
            this.Gauge_pressure.ScaleLinesMajorWidth = 2;
            this.Gauge_pressure.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.Gauge_pressure.ScaleLinesMinorInnerRadius = 75;
            this.Gauge_pressure.ScaleLinesMinorOuterRadius = 80;
            this.Gauge_pressure.ScaleLinesMinorTicks = 9;
            this.Gauge_pressure.ScaleLinesMinorWidth = 1;
            this.Gauge_pressure.ScaleNumbersColor = System.Drawing.Color.Black;
            this.Gauge_pressure.ScaleNumbersFormat = null;
            this.Gauge_pressure.ScaleNumbersRadius = 95;
            this.Gauge_pressure.ScaleNumbersRotation = 0;
            this.Gauge_pressure.ScaleNumbersStartScaleLine = 0;
            this.Gauge_pressure.ScaleNumbersStepScaleLines = 1;
            this.Gauge_pressure.Size = new System.Drawing.Size(214, 207);
            this.Gauge_pressure.TabIndex = 21;
            this.Gauge_pressure.Text = "aGauge1";
            this.Gauge_pressure.Value = 749F;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 478);
            this.Controls.Add(this.Gauge_pressure);
            this.Controls.Add(this.mediaplayerr);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.aGauge11);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayerr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AGauge aGauge11;
        private System.Windows.Forms.AGauge aGauge1;
        private AxWMPLib.AxWindowsMediaPlayer mediaplayerr;
        private System.Windows.Forms.AGauge Gauge_pressure;

    }
}