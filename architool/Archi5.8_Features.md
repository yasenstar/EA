# Archi 5.8 Features Deep-Dive

- [Archi 5.8 Features Deep-Dive](#archi-58-features-deep-dive)
  - [Legend](#legend)
    - [Enumerated Value for Legend Display Setting - `value:display`](#enumerated-value-for-legend-display-setting---valuedisplay)
    - [Sorting](#sorting)
    - [Colour Scheme](#colour-scheme)

## Legend

```xml
<child xsi:type="archimate:Note" id="id-8b7cd4e23d114ffc82890c2ce87ee8fa" name="Legend" fontColor="#80ffff" lineWidth="2" textAlignment="1" fillColor="#8080ff">
    <bounds x="864" y="72" width="193" height="154"/>
    <feature name="legend" value="display=11,rows=24,offset=10,color=1,sort=1"/>
    <feature name="gradient" value="0"/>
    <feature name="lineStyle" value="1"/>
</child>
```
### Enumerated Value for Legend Display Setting - `value:display`

| Display Code | Concepts-Elements | Concepts-Relationships| Specializations-Elements | Specialization-Relationships |
| --- | --- | --- | --- | --- |
| 0 |  |  |  | |
| 1 | Y |  |  |  |
| 2 |  | Y |  |  |
| 3 | Y | Y | | |
| 4 | | | Y | |
| 5 | Y | | Y | |
| 6 | | Y | Y | |
| 7 | Y | Y | Y | |
| 8 | | | | Y |
| 9 | Y | | | Y |
| 10 | | Y | | Y |
| 11| Y | Y | | Y |
| 12 | | | Y | Y |
| 13 | Y | | Y | Y |
| 14 | | Y | Y | Y |
| 15 | Y | Y | Y | Y |

### Sorting

- Category (default): `value="sort=1"`
- Name: `value="sort=0"`

### Colour Scheme

- None: `value="color=0"`
- Core (default): `value="color=1"`
- User: `value="color=2"`