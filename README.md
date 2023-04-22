<a name="readme-top"></a>

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/CaptainQwerty/ValorantAPIWrapper">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">Valorant API Wrapper</h3>

  <p align="center">
    A .NET wrapper for valorant-api.com
    <br />
    <a href="https://github.com/CaptainQwerty/ValorantAPIWrapper"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/CaptainQwerty/ValorantAPIWrapper">View Demo</a>
    ·
    <a href="https://github.com/CaptainQwerty/ValorantAPIWrapper/issues">Report Bug</a>
    ·
    <a href="https://github.com/CaptainQwerty/ValorantAPIWrapper/issues">Request Feature</a>
  </p>
</div>


## About The Project

A very simple project to help developers take advantage of the excellent work done by the Valorant-API.com - giving easy access to a portition of the more common parts of the Valorant-API as well as some additional functionality. 

ValorantAPIWrapper is not official and not endorsed by Riot Games in any way.
Riot Games, Valorant, and all associated properties are trademarks or registered trademarks of Riot Games, Inc.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- GETTING STARTED -->
## Getting Started

Here you can find the prerequisites and installation instructions.

### Prerequisites

* .NET Framework 4.6.1 or later

### Installation

TO BE WROTE ONCE ON NUGET

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- USAGE EXAMPLES -->
## Usage Examples

After installing the package you can follow any of the below examples to get started.

### Agents

```csharp
// Get a list of all playable agents in Valorant
var allAgents = Agents.GetAllAgents();

// Search for an agent by name
var searchResult = Agents.GetAgentByName("Jett");

// Get a random playable agent
var randomAgent = Agents.GetRandomAgent();
```

### Maps

```csharp
// Get a list of all maps in Valorant
var allMaps = Maps.GetAllMaps();

// Search for a map by name
var searchResult = Maps.GetMapByName("Ascent");

// Get a random map
var randomMap = Maps.GetRandomMap();
```

### Weapons

```csharp
// Get a list of all weapons in Valorant
var allWeapons = Weapons.GetAllWeapons();

// Search for a weapon by name
var searchResult = Weapons.GetWeaponByName("Vandal");
```


_For more examples, please refer to the [Documentation](https://example.com)_

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Acknowledgments

* [Valorant-API.com](https://valorant-api.com/)
* [Best-README-Template](https://github.com/othneildrew/Best-README-Template) - [Othneildrew](https://github.com/othneildrew/)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/CaptainQwerty/ValorantAPIWrapper.svg?style=for-the-badge
[contributors-url]: https://github.com/CaptainQwerty/ValorantAPIWrapper/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/CaptainQwerty/ValorantAPIWrapper.svg?style=for-the-badge
[forks-url]: https://github.com/CaptainQwerty/ValorantAPIWrapper/network/members
[stars-shield]: https://img.shields.io/github/stars/CaptainQwerty/ValorantAPIWrapper.svg?style=for-the-badge
[stars-url]: https://github.com/CaptainQwerty/ValorantAPIWrapper/stargazers
[issues-shield]: https://img.shields.io/github/issues/CaptainQwerty/ValorantAPIWrapper.svg?style=for-the-badge
[issues-url]: https://github.com/CaptainQwerty/ValorantAPIWrapper/issues
[license-shield]: https://img.shields.io/github/license/CaptainQwerty/ValorantAPIWrapper.svg?style=for-the-badge
[license-url]: https://github.com/CaptainQwerty/ValorantAPIWrapper/blob/master/LICENSE.txt
[product-screenshot]: images/screenshot.png