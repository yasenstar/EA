# Enterprise Architecture Cookbook

## Overview

'Architecture', in a broad sense, is the synergy of ART and SCIENCE in designing complex structures, such that functionality and complexity are controlled. The notion of architecture is used in a wide range of domains, from town planning to building and construction, and from computer hardware to information systems, each being characterized by the types of 'structures' or 'systems' being designed.

To begin with, architecture, and hence the architect, is concerned with understanding and defining the relationship between the users of the system and the system being designed itself. Based on a thorough understanding of its relationship, the architect defines and refines the essence of the system, i.e., its structure, behavior, and other properties.

This representation of the system's ESSENCE, also called the 'architecture' of the system, forms the basis for analysis, optimization, and validation and is the starting point for the further design, implementation, and construction of that system. The resulting artifacts, be they buildings or information systems, naturally have to conform to the original design. The definition of the architecture is the input for verifying this.

During this process, the architect needs to communicate with all stakeholders of the system, ranging from clients and users to those who build and maintain the resulting system. The architect needs to balance all their needs and constraints to arrive at a feasible and acceptable design.

Comparing to build a new house, or rebuild one existing one, building or rebuilding an organization is a much more complex and challenging task.

* First of all, the steps one has to take in order to \(re\)build an organization are not standardized.
  * One could start by first \(re\)designing business processes, followed by the application \(re\)design.
  * Or one could first design generic application services, followed by designing business processes on top of these.
* Secondly, building an organization is a complex and challenging task because of the multifarious dependencies within an organization.

Many \(often unknown\) above dependencies exist between various domains, like strategy, products and services, business processes, organizational structure, applications, information management and technical infrastructure. Besides having a good overview of these different domains, one needs to be aware of their interrelationships. Together, these form the _enterprise architecture_ of the organization.

The _enterprise architecture_ can be defined as the practice that tries to describe and control an organization's structure, processes, applications, systems, and technology in such an integrated way. More specifically, we focus on methods and techniques for making and using integrated descriptions by means of architecture models, visualization of these models for various stakeholders, and analysis of the impact of changes.

An architecture model is not just useful to provide insight into the current or future situation; it can also be used to evaluate the transition from 'as is' to 'to be'.

## 1. Introduction of Enterprise Architecture

Architecture is the art and science of designing complex structures.

Enterprise architecture, more specifically, is defined as a coherent whole of principles, methods, and models that are used in the design and realization of an enterprise's organizational structure, business processes, information systems, and infrastructure.

Architecture models, views, presentations, and analysis all help to bridge the 'communication gap' between architects and stakeholders.

Architecture is an indispensable instrument in controlling the complexity of the enterprise and its processes and systems.

* One the one hand, we see internal drivers for using an architectural approach, related to the strategy execution of an organization. Better alignment between business and IT leads to lower cost, higher quality, better time-to-market, and greater customer satisfaction.
* On the other hand, external drivers from regulatory authorities and other pressures necessitate companies to have a thorough insight into their structure and operations.

All of those drivers make a clear case for the use of enterprise architecture.

### Architecture

It is often said that to manage the **complexity** of any large organization or system, you need architecture. To create an overview of the structure of an organization, its business processes, their application support, and the technical infrastructure, you need to express the different **aspects** and **domains**, and their **relations**.

IEEE 1471-2000 / ISO/IEC 42010:2007 \(IEEE Computer Society 2000\) defines architecture as:

> **Architecture** is the fundamental organization of a system embodied in its components, their relationships to each other, and to the environment, and the principle guiding its design and evolution.

This definition accommodates both the blueprint and the general principles. More succinctly, we could define **architecture** as '**structure with a vision**'. An architecture provides an integrated view of the system being designed or studied.

In USA's Clinger-Cohen Act of 1996, also known as the Information Technology Management Reform Acts, demands that every government agency must have an IT architecture, which is defined as:

> The **IT Architecture** is an integrated framework for evolving or maintaining existing information technology and acquiring new information technology to achieve the agency's strategic goals and information resources management goals.

As well as the definition of architecture, following are two other definitions coming from IEEE standard:

> **Stakeholder**: an individual, team, or organization \(or classes thereof\) with interests in, or concerns relative to, a system.

Most stakeholders of a system are probably not interested in its architecture, but only in the impact of this on their concern. However, an architect needs to be aware of these concerns and discuss them with the stakeholders, and thus should be able to explain the architecture to all stakeholders involved, who will often have completely different backgrounds.

### Enterprise Architecture

> **Enterprise**: an collection of organizations that has a common set of goals and/or a single bottom line.

Architecture at the level of an entire organization is commonly referred to as 'enterprise architecture'. This leads to the definition of:

> **Enterprise Architecture**: a coherent \(相干\) whole of principles, methods and models that are used in the design and realization of an enterprise's organizational structure, business processes, information systems, and infrastructure.

Enterprise Architecture captures the **essentials** of the business, IT and its evolution. The idea is that the essentials are much **more stable** than the specific solutions that are found for the problems currently at hand. Architecture is therefore helpful in **guarding the essentials** of the business, while still **allowing for maximal flexibility and adaptivity**.

The most important characteristic of an enterprise architecture is that it provides a holistic view of the enterprise. What is part of the enterprise architecture, and what is only an implementation within that architecture, is a matter of what the business defines to be the architecture, and what not.

The architecture marks the separation between what should not be tampered \(篡改\) with and what can be filled in more freely. This places a high demand for quality on the architecture. **Quality** means that the architecture actually helps in achieving essential business objectives. In constructing and maintaining an architecture, choices should therefore be related to the business objectives, i.e., they should be rational.

Even though an architecture captures the relatively stable parts of business and technology, any architecture will need to accommodate and facilitate **change**, and architecture products will therefore only have a temporary status. Architectures change because the environment changes and new technological opportunities arise, and because of new insights as to what is essential to the business. To ensure that these essentials are discussed, a good architecture clearly shows the relation of the architectural decisions to the business objectives of the enterprise.

### The Architecture Process

Architecture is a process as well as a product.

* The product serves to guide managers in designing business processes and system developers in building applications in a way that is in line with business objectives and policies.
* The effects of the process reach further than the mere creation of the architecture product - the awareness of stakeholders with respect to business objectives and information flow will be raised.
* Also, once the architecture is created, it needs to be maintained. Businesses and IT are continually changing. This constant evolution is, ideally, a rational process.
* Change should only be initiated when people in power see an opportunity to strengthen business objectives.

### Drivers for Enterprise Architecture

Internal Drivers:

* Business-IT alignment is commonly recognized as an important instrument to realize organizational effectiveness. \(Effectiveness is driven by the relationship between components rather than by the detailed specification of each individual component. 'Alignment' includes the aspects of business strategy and organizational infrastructure on the one hand, and IT strategy and IT infrastructure on the other hand.
  * One can take the business strategy of an enterprise as the starting point, and derive its IT infrastructure either via an IT strategy or through the organisational infrastructure
  * Conversely, one can focus on IT as an enabler and start from the IT strategy, deriving the organizational infrastructure via a business strategy or based on the IT infrastructure.
* A well-defined architecture is an important asset in positioning new developments within the context of the existing processes, IT systems, and other assets of an organization, and it helps in identifying necessary changes. Thus, good architectural practice helps a company innovate and change by providing both **stability** and **flexibility**.
  * The insights provided by an enterprise architecture are needed on the one hand in determining the needs and priorities for change from a business perspective, and
  * on the other hand in assessing how the company may benefit from technological and business innovations.
* Architecture is a strategic instrument in guiding an organization through a planning course of development.
* The role of enterprise architecture is to organize logic for business processes and IT infrastructure, which must reflect the integration and standardization requirements of the operating model.

External drivers:

* The regulatory framework increasingly demands that companies and governmental institutions can prove that they have a clear insight into their operations and that they comply with the applicable laws on, say, financial transactions.
  * The US Clinger-Cohen Act of 1996, also known as the Information Technology Management Reform Act, has been an important stimulus for the development of enterprise architecture as a discipline, not just in a government context, but in general
  * The capital adequacy framework knows as Basel II, imposes strict regulations on banks in terms of risk measurement and management, with wide-ranging implications for both their organizations and their IT systems.
  * Another US act, the Sarbanes-Oxley Act of 2002, has a major impact to force companies to adopt good corporate governance practices and to make company executives personally accountable.

## 2. State of the Art

1. Position enterprise architecture relative to a number of well-known standards and best practices in general and IT management.
2. Outline the most important frameworks and methods for enterprise architecture
3. Service orientation, the most important architecture paradigm
4. A number of relevant languages for modelling organization, business processes, applications, and technology

### Enterprise Architecture and Other Governance Instruments

Enterprise architecture is typically used as an instrument in managing a company's daily operations and future development.

* Strategic Management: the Balanced Scorecard \(Kaplan and Norton 1992\)
* Strategy Execution: EFQM
* Quality Management: ISO 9001
* IT Governance: COBIT
* IT Delivery and Support: ITIL
* IT Implementation: CMM and CMMI

## Key Parameters for Evaluation

There are eight key parameters to identify the winners

Reference from: https://www.architecturerating.com/chief-architects

1. Measurable Results: Ability to meet the business goal and stakeholder expectations
2. Decision Making: Leadership in decision making (new thinking, the action plan, etc.)
3. Enterprise & IT Architecture: Contribution to the growth of the discipline (Enterprise & IT Architecture)
4. Ground Breaking Projects: M & A, Growing Business in New Territory, New Service Offering etc., IT Product 
5. Efficiency Initiatives: IT Landscape Rationalisation, Business Process Improvements, Architecture Governance, Architecture Methodology, IT Infrastructure, IT Security
6. State of the Art (Technology adoption): IoT Enabled Solution, Future IT (Emerging Technologies), Cloud Technologies and Solutions, SoA Vision for Enterprise Services, 
7. Change Agent: Business Strategy to Execution, Business Architecture, Business Transformation, Digital Architecture, Enterprise Architecture
8. Innovation: Industry Leading Solutions, Customer Oriented Business Models, Supply Chain & Logistics,

## Sources

* Enterprise Architecture as Work, 2nd edition



