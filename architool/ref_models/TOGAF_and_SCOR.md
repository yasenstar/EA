# Skills Framework for TOGAF & SCOR

TOGAF - The Open Group Architecture Framework
SCOR - Supply Chain Operations Framework

Source: Orbus Software
Author: Mitchell Wightman (Enterprise Account Executive at Orbus Software)

## Part 1 - TOGAF Framework Overview

Link: https://www.orbussoftware.com/resources/blog/article/skills-framework-for-togaf-scor-part-1-togaf-framework-overview

**TOGAF provides a skills framework that can assist in preparing role definitions and planning training. This post examines several ways they can be expanded.**

_The TOGAF framework has its detractors, but they (and some of the larger number of advocates) often miss the point of TOGAF – it's not a step-by step architecture-by-numbers guide, it's more a grab bag of tools encapsulating best practices from the experiences of others. I tell people that they should expect to borrow from TOGAF instead of adopting it wholesale – after all, step 4 of the preliminary phase is to tailor the architecture framework. In the next four posts I’m going to talk about one of these tools that people often overlook, the TOGAF skills framework, and consider how it could be expanded by borrowing ideas from it to another skills framework in a different standard._

Summary: TOGAF provides a skills framework that can assist in preparing role definitions and planning training. However, there are several ways that it could be expanded, and in this post I examine what they are.

The TOGAF skills framework appears in chapter 52, the final chapter of TOGAF (this may be why so many people forget its existence). It defines roughly 75 skills, grouped into the headings of Generic Skills, Business Skills & Methods, Enterprise Architecture Skills, Program or Project Management Skills, IT General Knowledge Skills, Technical IT Skills, Legal Environment. These skills are then plotted against 9 specific roles:

- Architecture Board member
- Architecture Sponsor
- Enterprise Architecture Manager
- Enterprise Architect - Technology
- Enterprise Architect - Data
- Enterprise Architect - Applications
- Enterprise Architect - Business
- Program/project manager
- IT Designer
- 
For each skill/role intersection, the desired skill level in that skill for that role is rated on a scale of 1-4;

1. Background – not a required skill, though should be able to define and manage skill if required
2. Awareness – Understands the background, issues, and implications sufficiently to be able to understand how to proceed further and advise client accordingly
3. Knowledge – Detailed knowledge of subject area and capable of providing professional advice and guidance. Ability to integrate capability into architecture design.
4. Expert – Extensive and substantial practical experience and applied knowledge on the subject

(from TOGAF, chapter 52)

Now, this is all helpful. But there's some other information that I wish it could offer me.

First of all, while it is useful to have these roles defined, they are pretty tightly defined. For example, what profile should a security architect have? Secondly, there is no definition of what each skill actually means. It may or may not be useful to know that each of the Enterprise Architects and the Enterprise Architect should be an expert in ‘Enterprise Continuums’, but it is hard to judge whether they are or not without a better knowledge of what the skill actually involves. Essentially, the rating system is based on the approach of “I know it when I see it”. The final thing that I personally would like to see in this section is some guidance in how someone could move up the skill levels for a given skill. What is the development path that I should define for myself, or my team?

Now, every standard does face constraints in resource that can be expended – the authors of TOGAF have day jobs as well, so they needed to define their scope in terms of what could be delivered in a given timeframe. But it feels like the TOGAF skills framework is a part of the standard that could be expanded upon usefully.

In the next blog post I’m going to examine SCOR, and its approach to skills mapping.

## Part 2 – SCOR Framework Overview

**An overview of the SCOR – Supply Chain Operations Framework. One of the various things it does well is the skills framework, which is looked at in this post.**

_Frameworks, I love them – let’s have lots of them. We have TOGAF and DODAF and MODAF and PEAF. We have BIAN and ACORD and APQC… one of the industry specific ones is called SCOR – Supply Chain Operations Framework. It’s actually an excellent and very mature standard within the scope of what it does, and it offers several ideas that an organization could borrow to expand the TOGAF skills framework._

Summary: The Supply Chain Operations Framework is not very well known outside of its specific market, which is a pity, as it’s a rather nicely put together framework, albeit with a limited scope. One of the various things it does well is the skills framework, which we look at in this post.

The key point about SCOR is that it is based around processes. This shouldn’t be surprising given that it’s a standard that focuses on operational excellence in supply chains. Processes are defined for 5 major level 1 process areas – Plan, Source, Make, Deliver and Return. Within each of these areas, SCOR defines a set of subprocesses.

What that means in terms of the SCOR skills framework, is that each process is mapped to a number of skills that support that process. The mapping is many to many; a given skill supports multiple processes, each of which relies on several skills. Each skill is described and should be rated for a given person or role on a scale of 1 to 5:

1. Novice – Untrained beginner, no experience, requires and follows detailed documentation to be able to perform the work.
2. Experienced beginner – Performs the work; limited situational perception.
3. Competent – Understands the work and can determine priorities to reach organizational goals.
4. Proficient – Oversees all aspects of the work and can prioritize based on situational aspects.
5. Expert – Intuitive understanding. Experts can apply experience patterns to new situations.

However, the SCOR framework does not simply stop there. Each skill is mapped to three elements that affect the skill level.

Aptitudes represent an innate affinity to a particular activity. For example, some people have a natural ability with arithmetic; this affinity can be useful in applying the skill of stock checking.

Experiences represent time spent engaging in an activity, so that the person with that experience is familiar with the expected situation and the unexpected contingencies that can occur.

Last of all comes training – specific knowledge transfer that the person has undergone. This could be formal or informal – the specification does not make any distinction in this regard.

In each case, there can be a many to many relationship. A given skill can be affected by several aptitudes, several experiences and several forms of training. Likewise, each aptitude can affect several skills.

What this means in practice is that for a given business process, you can walk a notional graph to derive a specification for the profile of the person performing the process – what skills, and hence, what aptitudes, experiences and training that they should have. Used within a modeling tool that supports analysis, it is possible to derive this list automatically.

Now, this doesn't solve the objectives that we examined in the first post. First of all, there are arguably some noticeable gaps in the SCOR skills framework; also, it is only concerned with process modeling for supply chains – so its applicability to Enterprise Architecture is... shall we say... limited.  But it does at least offer some ideas for how we could expand the work done by the TOGAF authors.

Steve Jobs used to love to quote Picasso - “Good artists copy, great artists steal.” SCOR's approach to skills modeling seems eminently steal-able for our purposes.

## Part 3 – 3 Differences

**Having looked at 2 different skills frameworks in 2 different standards, it’s time to stop and consider the relative strengths & weaknesses of each one.**

Summary: Having looked at two different skills frameworks in two different standards, it’s time to stop and consider the relative strengths and weaknesses of both TOGAF & SCOR. The differences imply a different objective for each framework…but since the two approaches do not contradict each other, the door is open to combining the strengths of each.

To some extent, the differences between the skills framework in TOGAF and the skills framework in SCOR are a result of the two frameworks having differing opinions about what the purpose of a skills framework is (or rather, what they want to achieve with their particular skills frameworks).

The TOGAF skills framework seems to be almost completely aimed at specifying the roles of involved parties, in particular the roles for an enterprise transformation effort as envisioned by the TOGAF Architecture Development Method. This is seen in the way that it focused on defining desired skill levels for a set of predefined roles. So the TOGAF skills framework seems to target the enablement of an organization to staff its roles within an Enterprise Architecture function sufficiently for their Enterprise Architecture initiative to succeed.

It’s possible that this brevity is deliberate. At more than 700 pages, the TOGAF 9.1 specification is already an impressively large document. Indeed, many people who’ve studied TOGAF have been surprised when I inform them that the final chapter of TOGAF contains a discussion of necessary skills. So it may be that the omission of a more detailed skills framework was simply a matter of choosing scope.

Now, in contrast to the TOGAF skills framework, the SCOR skills framework seems to be more aimed at the development of skills. This is seen in the way that it looks to define, for each skill, what aptitudes a person needs to have to obtain a certain level of skill, what experiences that they must have to obtain a certain level of skill, and training that they must have to obtain a certain level of skill. In this way it becomes possible to define a plan for continuing education as well as a role profile.

However, what is perhaps surprising as an omission from SCOR is the complete absence of roles – in other words, what roles should have what skills. The supply chain area seems mature and well-defined enough to enable the definition of specific roles … it’s possible that the absence of roles may be because the SCOR processes don’t go to the level of role-based flows.  Given the rigor that the other parts of SCOR offer, we can speculate that the authors decided to omit roles until they could be integrated fully into every part of the framework – whether by RACI or in actual BPMN flows.

So the two frameworks both have aspects that the other lacks – and as stated, the choice of scope may have been a deliberate factor for both of the standards. In the final part of this series, we’ll consider how the two approaches could complement each other and speculate on possible ways that the TOGAF skills framework could be improved.

## Part 4 – Conclusions

**Concluding the series with some observations about how TOGAF might benefit from drawing from the alternative approach that we have seen.**

Summary: To conclude, I offer some observations about how TOGAF might benefit from drawing from the alternative approach that we have seen.

It’s the natural state of affairs that people are often not completely prepared for the jobs that they are in. People get promoted, and want to get promoted. This is actually a desirable situation – someone who is in a job that they know inside out is either lazy or bored witless, neither of which bodes well for enthusiasm and energy. But it does pose the challenge of how they, and their employer, can give them the skills that they are lacking.

There’s a general move within larger organizations to adopt formal programs to manage the skillsets of employees. One of the largest growth areas in recent years is the rise of Learning Management Systems (LMSs); both for corporations, for their internal learning, and for training providers, where both course attendees and those paying for the courses can track their progress. For example, Orbus Software’s learning partner, Good eLearning has recently implemented such a system, and more than a few clients who I’ve been with in recent years has had an LMS project ongoing while I’ve been there.

At the same time, the Open Group has shown a desire to provide a training and career path for architects. As well as the more technical certifications such as for TOGAF and Archimate, there is the more holistic, experience-based certification of the Open CA program.

Certifications have historically been subject to some suspicion on the part of practitioners in the field that they apply to, and with some justification. Too many hiring managers confuse certification in one area with competence in all the other fields that the job requires. But too my mind, this is not a reason to see certifications as bad as such – the issue is with how the certifications are used by others, not with the certifications themselves.

I have a number of certifications – ITIL, TOGAF and so on – dating from my time at Orbus Software. Orbus Software actively encourages all its employees to pursue industry certifications. But I don’t see my Archimate certification as qualifying me as an architect, any more than a certification in, say, .NET would qualify me as a senior .NET developer. To me, the personal value of a certification is that it helps guide my learning. The syllabus almost serves as a reading list, whether I pursue the certification or not.

With this in mind, I think there’s a definite opportunity to define learning paths for architectural practitioners to gain the skillsets that they need. How can a practitioner gain an ‘Expert’ level of knowledge in data protection legislation (to quote one item from the TOGAF skills framework)? How can they gain a ‘Knowledge’ level of ‘International Operations’?

It seems that there’s a real opportunity to expand upon the TOGAF skills framework to define more detailed learning paths for architects. The SCOR skills framework offers one pretty detailed approach that could be used to accomplish this.