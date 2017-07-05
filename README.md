<h1 align="center">renamer</h1>
<p align="center">Sort <a href="https://github.com/lap00zza/Grabber">Grabber</a> Episodes</p>
<p align="center"><img src="https://user-images.githubusercontent.com/10241434/27852936-a7597ad8-6193-11e7-802f-144bdc59173c.png"></p>

# About
This is one of my smaller projects...

It is used in conjunction with [Grabber](https://github.com/lap00zza/Grabber).
Grabber is used to download streams from 9Anime, and Renamer is used to parse the generated `metadata.json`.
It will rename the downloaded episodes to their real names, e.g: `bVTiwZTHZS2Lmme.mp4` to `some_delightful_episode-ep_001-standard.mp4`.

# Usage
> NOTE: It is assumed you have already downloaded videos using the [Grabber](https://github.com/lap00zza/Grabber) add-on.
Check out its [README](https://github.com/lap00zza/Grabber/blob/master/README.md) for instructions on how to use it!

## GUI
1. Select the `metadata.json` file which Grabber generated.
2. Select the folder where the episodes have been downloaded.
3. Click on the `Rename Episode Files` button, and you're done!

## CLI
```
renamer.cli.exe "metada.json" "path\to\episodes\folder"
```

# Requirements
- Lap00zza's [Grabber](https://github.com/lap00zza/Grabber)
- .NET Framework 4.5

# License
```
The MIT License (MIT)

Copyright (c) 2017 Roman Emilian

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
```
