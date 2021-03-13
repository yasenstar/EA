Run `./Archi` using normal user:

Error Message:

```
xdbcommon: ERROR: Key "<CAPS>" added to modifier map for multiple modifiers; Using Mod3, ignoring Lock
xdbcommon: ERROR: Key "<CAPS>" added to modifier map for multiple modifiers; Using Mod3, ignoring Lock

(Archi: 6861): Gtk-CRITICAL **: timestamp: gtk_distribute_natural_allocation: assertion 'extra_spack >= 0' failed

(Archi: 6861): Gtk-CRITICAL **: timestamp: gtk_box_gadget_distribution: assertion 'size >= 0' failed in GtkScrollbar

(Archi: 6861): Gtk-CRITICAL **: timestamp: gtk_box_gadget_distribution: assertion 'size >= 0' failed in GtkScrollbar

(Archi: 6861): Gtk-WARNING*: timestamp: Negative content height -9 (allocation 1, extents 5x5) while allocating oggleButton

...repeat the 'size >= 0' line
```

With these errors/warnings, the Archi is able to be opened, just the display is not looks beautiful.

Using `sudo ./Archi`

Get following error:

```
No protocol specified
Unable to init server: Could not connect: Connection refused
Archi: Cannot open display:
```

This is expected, since I think both Eclipse and Archi are extracted in my user account directory, when switching the `su`, there's no programs there to be loaded.

However, I still think it may be different when using higher privilege user to try.

Then directly using `su` to go to the Root.

By default, in ChromeOS Linux Root folder is empty.

Copy Archi, .archi4, eclipse folder to Root directory:

```
cp -r /home/[username]/Archi ~/
cp -r /home/[username]/.archi4 ~/
cp -r /home/[username]/eclipse ~/
```

The contents (including hidden) under root is like below:

```
.   ..  Archi   .archi4 .bashrc .cache  .profile    eclipse
```

At root, check Java version, which is `openjdk 11.0.9.1 2020-11-04`

Now run `./Archi` in Archi folder directly, still error, but message little different now:

```
No protocol specified

(java:7061): dbind-WARNING **: (timestamp): Cloud not open X display
No protocol specified

(java:7084): dbind-WARNING **: (timestamp)