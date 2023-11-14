﻿using System;
using System.Diagnostics;

namespace Fall2020_CSC403_Project {
  partial class FrmLevel {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
      this.lblInGameTime = new System.Windows.Forms.Label();
      this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
      this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
      this.picWall11 = new System.Windows.Forms.PictureBox();
      this.picWall2 = new System.Windows.Forms.PictureBox();
      this.picWall8 = new System.Windows.Forms.PictureBox();
      this.picWall7 = new System.Windows.Forms.PictureBox();
      this.picWall1 = new System.Windows.Forms.PictureBox();
      this.picWall0 = new System.Windows.Forms.PictureBox();
      this.picWall10 = new System.Windows.Forms.PictureBox();
      this.picWall9 = new System.Windows.Forms.PictureBox();
      this.picWall6 = new System.Windows.Forms.PictureBox();
      this.picWall12 = new System.Windows.Forms.PictureBox();
      this.picWall4 = new System.Windows.Forms.PictureBox();
      this.picWall5 = new System.Windows.Forms.PictureBox();
      this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
      this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
      this.picWall3 = new System.Windows.Forms.PictureBox();
      this.picBossKoolAid = new System.Windows.Forms.PictureBox();
      this.picPlayer = new System.Windows.Forms.PictureBox();
      this.weapon1 = new System.Windows.Forms.PictureBox();
      this.healthPackLvl1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.weapon1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.healthPackLvl1)).BeginInit();
      this.SuspendLayout();
      // 
      // lblInGameTime
      // 
      this.lblInGameTime.AutoSize = true;
      this.lblInGameTime.BackColor = System.Drawing.Color.Black;
      this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblInGameTime.ForeColor = System.Drawing.Color.White;
      this.lblInGameTime.Location = new System.Drawing.Point(32, 22);
      this.lblInGameTime.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
      this.lblInGameTime.Name = "lblInGameTime";
      this.lblInGameTime.Size = new System.Drawing.Size(121, 44);
      this.lblInGameTime.TabIndex = 2;
      this.lblInGameTime.Text = "label1";
      // 
      // tmrUpdateInGameTime
      // 
      this.tmrUpdateInGameTime.Enabled = true;
      this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
      // 
      // tmrPlayerMove
      // 
      this.tmrPlayerMove.Enabled = true;
      this.tmrPlayerMove.Interval = 10;
      this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
      // 
      // picWall11
      // 
      this.picWall11.BackColor = System.Drawing.Color.Transparent;
      this.picWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.brick;
      this.picWall11.Location = new System.Drawing.Point(1470, 1014);
      this.picWall11.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picWall11.Name = "picWall11";
      this.picWall11.Size = new System.Drawing.Size(437, 555);
      this.picWall11.TabIndex = 17;
      this.picWall11.TabStop = false;
      // 
      // picWall2
      // 
      this.picWall2.BackColor = System.Drawing.Color.Transparent;
      this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.brick;
      this.picWall2.Location = new System.Drawing.Point(1470, 2);
      this.picWall2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picWall2.Name = "picWall2";
      this.picWall2.Size = new System.Drawing.Size(1250, 158);
      this.picWall2.TabIndex = 16;
      this.picWall2.TabStop = false;
      // 
      // picWall8
      // 
      this.picWall8.BackColor = System.Drawing.Color.Transparent;
      this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.brick;
      this.picWall8.Location = new System.Drawing.Point(2914, 653);
      this.picWall8.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picWall8.Name = "picWall8";
      this.picWall8.Size = new System.Drawing.Size(219, 1071);
      this.picWall8.TabIndex = 15;
      this.picWall8.TabStop = false;
      // 
      // picWall7
      // 
      this.picWall7.BackColor = System.Drawing.Color.Transparent;
      this.picWall7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWall7.BackgroundImage")));
      this.picWall7.Location = new System.Drawing.Point(1904, 1564);
      this.picWall7.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picWall7.Name = "picWall7";
      this.picWall7.Size = new System.Drawing.Size(1013, 158);
      this.picWall7.TabIndex = 14;
      this.picWall7.TabStop = false;
      // 
      // picWall1
      // 
      this.picWall1.BackColor = System.Drawing.Color.Transparent;
      this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.brick;
      this.picWall1.Location = new System.Drawing.Point(222, 2);
      this.picWall1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picWall1.Name = "picWall1";
      this.picWall1.Size = new System.Drawing.Size(1250, 158);
      this.picWall1.TabIndex = 13;
      this.picWall1.TabStop = false;
      // 
      // picWall0
      // 
      this.picWall0.BackColor = System.Drawing.Color.Transparent;
      this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.brick;
      this.picWall0.Location = new System.Drawing.Point(5, 2);
      this.picWall0.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picWall0.Name = "picWall0";
      this.picWall0.Size = new System.Drawing.Size(219, 927);
      this.picWall0.TabIndex = 12;
      this.picWall0.TabStop = false;
      // 
      // picWall10
      // 
      this.picWall10.BackColor = System.Drawing.Color.Transparent;
      this.picWall10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWall10.BackgroundImage")));
      this.picWall10.Location = new System.Drawing.Point(1742, 214);
      this.picWall10.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picWall10.Name = "picWall10";
      this.picWall10.Size = new System.Drawing.Size(608, 386);
      this.picWall10.TabIndex = 11;
      this.picWall10.TabStop = false;
      // 
      // picWall9
      // 
      this.picWall9.BackColor = System.Drawing.Color.Transparent;
      this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.brick;
      this.picWall9.Location = new System.Drawing.Point(709, 369);
      this.picWall9.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picWall9.Name = "picWall9";
      this.picWall9.Size = new System.Drawing.Size(526, 281);
      this.picWall9.TabIndex = 10;
      this.picWall9.TabStop = false;
      // 
      // picWall6
      // 
      this.picWall6.BackColor = System.Drawing.Color.Transparent;
      this.picWall6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWall6.BackgroundImage")));
      this.picWall6.Location = new System.Drawing.Point(953, 1564);
      this.picWall6.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picWall6.Name = "picWall6";
      this.picWall6.Size = new System.Drawing.Size(955, 158);
      this.picWall6.TabIndex = 9;
      this.picWall6.TabStop = false;
      // 
      // picWall12
      // 
      this.picWall12.BackColor = System.Drawing.Color.Transparent;
      this.picWall12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWall12.BackgroundImage")));
      this.picWall12.Location = new System.Drawing.Point(2373, 947);
      this.picWall12.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picWall12.Name = "picWall12";
      this.picWall12.Size = new System.Drawing.Size(542, 270);
      this.picWall12.TabIndex = 8;
      this.picWall12.TabStop = false;
      // 
      // picWall4
      // 
      this.picWall4.BackColor = System.Drawing.Color.Transparent;
      this.picWall4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWall4.BackgroundImage")));
      this.picWall4.Location = new System.Drawing.Point(5, 1083);
      this.picWall4.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picWall4.Name = "picWall4";
      this.picWall4.Size = new System.Drawing.Size(219, 484);
      this.picWall4.TabIndex = 7;
      this.picWall4.TabStop = false;
      // 
      // picWall5
      // 
      this.picWall5.BackColor = System.Drawing.Color.Transparent;
      this.picWall5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWall5.BackgroundImage")));
      this.picWall5.Location = new System.Drawing.Point(5, 1564);
      this.picWall5.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picWall5.Name = "picWall5";
      this.picWall5.Size = new System.Drawing.Size(955, 158);
      this.picWall5.TabIndex = 6;
      this.picWall5.TabStop = false;
      // 
      // picEnemyCheeto
      // 
      this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
      this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
      this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picEnemyCheeto.Location = new System.Drawing.Point(2235, 1288);
      this.picEnemyCheeto.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picEnemyCheeto.Name = "picEnemyCheeto";
      this.picEnemyCheeto.Size = new System.Drawing.Size(171, 256);
      this.picEnemyCheeto.TabIndex = 5;
      this.picEnemyCheeto.TabStop = false;
      // 
      // picEnemyPoisonPacket
      // 
      this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
      this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
      this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picEnemyPoisonPacket.Location = new System.Drawing.Point(212, 304);
      this.picEnemyPoisonPacket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
      this.picEnemyPoisonPacket.Size = new System.Drawing.Size(167, 229);
      this.picEnemyPoisonPacket.TabIndex = 4;
      this.picEnemyPoisonPacket.TabStop = false;
      // 
      // picWall3
      // 
      this.picWall3.BackColor = System.Drawing.Color.Transparent;
      this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.brick;
      this.picWall3.Location = new System.Drawing.Point(5, 927);
      this.picWall3.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picWall3.Name = "picWall3";
      this.picWall3.Size = new System.Drawing.Size(955, 158);
      this.picWall3.TabIndex = 3;
      this.picWall3.TabStop = false;
      // 
      // picBossKoolAid
      // 
      this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
      this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
      this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picBossKoolAid.Location = new System.Drawing.Point(2590, 177);
      this.picBossKoolAid.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picBossKoolAid.Name = "picBossKoolAid";
      this.picBossKoolAid.Size = new System.Drawing.Size(514, 463);
      this.picBossKoolAid.TabIndex = 1;
      this.picBossKoolAid.TabStop = false;
      // 
      // picPlayer
      // 
      this.picPlayer.BackColor = System.Drawing.Color.Transparent;
      this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
      this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPlayer.Location = new System.Drawing.Point(318, 1217);
      this.picPlayer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.picPlayer.Name = "picPlayer";
      this.picPlayer.Size = new System.Drawing.Size(144, 251);
      this.picPlayer.TabIndex = 0;
      this.picPlayer.TabStop = false;
      // 
      // weapon1
      // 
      this.weapon1.BackColor = System.Drawing.Color.Transparent;
      this.weapon1.Image = global::Fall2020_CSC403_Project.Properties.Resources.weapon1;
      this.weapon1.Location = new System.Drawing.Point(2533, 1350);
      this.weapon1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.weapon1.Name = "weapon1";
      this.weapon1.Size = new System.Drawing.Size(290, 101);
      this.weapon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.weapon1.TabIndex = 18;
      this.weapon1.TabStop = false;
      // 
      // healthPackLvl1
      // 
      this.healthPackLvl1.BackColor = System.Drawing.Color.Transparent;
      this.healthPackLvl1.Image = global::Fall2020_CSC403_Project.Properties.Resources.health_pack;
      this.healthPackLvl1.Location = new System.Drawing.Point(226, 181);
      this.healthPackLvl1.Name = "healthPackLvl1";
      this.healthPackLvl1.Size = new System.Drawing.Size(66, 67);
      this.healthPackLvl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.healthPackLvl1.TabIndex = 19;
      this.healthPackLvl1.TabStop = false;
      // 
      // FrmLevel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.gravel;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1924, 1047);
      this.Controls.Add(this.healthPackLvl1);
      this.Controls.Add(this.picWall11);
      this.Controls.Add(this.picWall2);
      this.Controls.Add(this.picWall8);
      this.Controls.Add(this.picWall7);
      this.Controls.Add(this.lblInGameTime);
      this.Controls.Add(this.picWall1);
      this.Controls.Add(this.picWall0);
      this.Controls.Add(this.picWall10);
      this.Controls.Add(this.picWall9);
      this.Controls.Add(this.picWall6);
      this.Controls.Add(this.picWall12);
      this.Controls.Add(this.picWall4);
      this.Controls.Add(this.picWall5);
      this.Controls.Add(this.picWall3);
      this.Controls.Add(this.picPlayer);
      this.Controls.Add(this.picEnemyPoisonPacket);
      this.Controls.Add(this.picBossKoolAid);
      this.Controls.Add(this.picEnemyCheeto);
      this.Controls.Add(this.weapon1);
      this.DoubleBuffered = true;
      this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
      this.MaximumSize = new System.Drawing.Size(1215, 765);
      this.MinimumSize = new System.Drawing.Size(1215, 765);
      this.Name = "FrmLevel";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Explore";
      this.Load += new System.EventHandler(this.FrmLevel_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
      ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.weapon1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.healthPackLvl1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picBossKoolAid;
    private System.Windows.Forms.Label lblInGameTime;
    private System.Windows.Forms.Timer tmrUpdateInGameTime;
    private System.Windows.Forms.Timer tmrPlayerMove;
    private System.Windows.Forms.PictureBox picWall3;
    private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
    private System.Windows.Forms.PictureBox picEnemyCheeto;
    private System.Windows.Forms.PictureBox picWall5;
    private System.Windows.Forms.PictureBox picWall4;
    private System.Windows.Forms.PictureBox picWall12;
    private System.Windows.Forms.PictureBox picWall6;
    private System.Windows.Forms.PictureBox picWall9;
    private System.Windows.Forms.PictureBox picWall10;
    private System.Windows.Forms.PictureBox picWall0;
    private System.Windows.Forms.PictureBox picWall7;
    private System.Windows.Forms.PictureBox picWall8;
    private System.Windows.Forms.PictureBox picWall1;
    private System.Windows.Forms.PictureBox picWall2;
    private System.Windows.Forms.PictureBox picWall11;
    private System.Windows.Forms.PictureBox weapon1;
    private System.Windows.Forms.PictureBox picNetherPortal;
    private System.Windows.Forms.PictureBox healthPackLvl1;
  }
}

